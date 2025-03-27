using System;
using System.IO;
using System.Data.SQLite;

namespace MyDictionary.DataAccess
{
    public class DatabaseManager
    {
        private readonly string _dbPath;
        private readonly string _connectionString;

        public DatabaseManager()
        {
            // Lấy thư mục gốc của dự án thay vì thư mục bin/Debug
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

            // Đảm bảo database luôn nằm trong thư mục "Database" ở gốc dự án
            string folderPath = Path.Combine(projectRoot, "Database");
            _dbPath = Path.Combine(folderPath, "myDictionary.db");
            _connectionString = $"Data Source={_dbPath};Version=3;";
        }

        public void InitializeDatabase()
        {
            Console.WriteLine("Đang khởi tạo database...");

            if (!File.Exists(_dbPath))
            {
                Console.WriteLine("Tạo thư mục Database nếu chưa có...");
                Directory.CreateDirectory(Path.GetDirectoryName(_dbPath));

                Console.WriteLine("Tạo file database...");
                SQLiteConnection.CreateFile(_dbPath);

                Console.WriteLine($"Database được tạo tại: {_dbPath}");

                // Tạo bảng
                CreateTables();
            }
            else
            {
                Console.WriteLine($"Database đã tồn tại tại: {_dbPath}");
            }
        }

        private void CreateTables()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string[] tableQueries = new string[]
                {
    @"CREATE TABLE IF NOT EXISTS Frequency (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Level TEXT NOT NULL,
        Description TEXT
    );",

    @"CREATE TABLE IF NOT EXISTS Word (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Text TEXT NOT NULL UNIQUE,
        Pronunciation TEXT,
        Notes TEXT,
        FrequencyId INTEGER,
        FOREIGN KEY (FrequencyId) REFERENCES Frequency(Id) ON DELETE SET NULL
    );",

    @"CREATE TABLE IF NOT EXISTS WordType (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Abbreviation TEXT NOT NULL UNIQUE,
        Name TEXT NOT NULL,
        ParentId INTEGER
    );",

    @"CREATE TABLE IF NOT EXISTS Word_WordType (
        WordId INTEGER NOT NULL,
        WordTypeId INTEGER NOT NULL,
        PRIMARY KEY (WordId, WordTypeId),
        FOREIGN KEY (WordId) REFERENCES Word(Id) ON DELETE CASCADE,
        FOREIGN KEY (WordTypeId) REFERENCES WordType(Id) ON DELETE CASCADE
    );",

    @"CREATE TABLE IF NOT EXISTS Topic (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Name TEXT NOT NULL UNIQUE,
        Image TEXT,
        Notes TEXT
    );",

    @"CREATE TABLE IF NOT EXISTS Word_Topic (
        TopicId INTEGER NOT NULL,
        WordId INTEGER NOT NULL,
        PRIMARY KEY (TopicId, WordId),
        FOREIGN KEY (TopicId) REFERENCES Topic(Id) ON DELETE CASCADE,
        FOREIGN KEY (WordId) REFERENCES Word(Id) ON DELETE CASCADE
    );",

    @"CREATE TABLE IF NOT EXISTS SynonymGroup (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Meaning TEXT NOT NULL
    );",

    @"CREATE TABLE IF NOT EXISTS WordSynonym (
        WordId INTEGER NOT NULL,
        SynonymGroupId INTEGER NOT NULL,
        PRIMARY KEY (WordId, SynonymGroupId),
        FOREIGN KEY (WordId) REFERENCES Word(Id) ON DELETE CASCADE,
        FOREIGN KEY (SynonymGroupId) REFERENCES SynonymGroup(Id) ON DELETE CASCADE
    );",

    @"CREATE TABLE IF NOT EXISTS Antonym (
        Word1Id INTEGER NOT NULL,
        Word2Id INTEGER NOT NULL,
        PRIMARY KEY (Word1Id, Word2Id),
        FOREIGN KEY (Word1Id) REFERENCES Word(Id) ON DELETE CASCADE,
        FOREIGN KEY (Word2Id) REFERENCES Word(Id) ON DELETE CASCADE
    );",

    @"CREATE TABLE IF NOT EXISTS Tag (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Name TEXT NOT NULL UNIQUE,
        Note TEXT
    );",

    @"CREATE TABLE IF NOT EXISTS Tag_WordStruct (
        TagId INTEGER NOT NULL,
        WordId INTEGER,
        StructureId INTEGER,
        PRIMARY KEY (TagId, WordId, StructureId),
        FOREIGN KEY (TagId) REFERENCES Tag(Id) ON DELETE CASCADE,
        FOREIGN KEY (WordId) REFERENCES Word(Id) ON DELETE CASCADE,
        FOREIGN KEY (StructureId) REFERENCES GrammarStructure(Id) ON DELETE CASCADE
    );",

    @"CREATE TABLE IF NOT EXISTS Option (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        OptionCode TEXT NOT NULL UNIQUE,
        TypeOption TEXT NOT NULL
    );",

    @"CREATE TABLE IF NOT EXISTS Tag_Option (
        TagId INTEGER NOT NULL,
        OptionId INTEGER NOT NULL,
        PRIMARY KEY (TagId, OptionId),
        FOREIGN KEY (TagId) REFERENCES Tag(Id) ON DELETE CASCADE,
        FOREIGN KEY (OptionId) REFERENCES Option(Id) ON DELETE CASCADE
    );",

    @"CREATE TABLE IF NOT EXISTS GrammarPart (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        WordId INTEGER,
        WordTypeId INTEGER,
        FOREIGN KEY (WordId) REFERENCES Word(Id) ON DELETE CASCADE,
        FOREIGN KEY (WordTypeId) REFERENCES WordType(Id) ON DELETE CASCADE
    );",

    @"CREATE TABLE IF NOT EXISTS GrammarStructure (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Name TEXT NOT NULL UNIQUE,
        Notes TEXT
    );",

    @"CREATE TABLE IF NOT EXISTS GrammarFormula (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        GrammarStructureId INTEGER NOT NULL,
        Formula TEXT NOT NULL,
        FOREIGN KEY (GrammarStructureId) REFERENCES GrammarStructure(Id) ON DELETE CASCADE
    );",

    @"CREATE TABLE IF NOT EXISTS GrammarStructure_Part (
        GrammarFormulaId INTEGER NOT NULL,
        GrammarPartId INTEGER NOT NULL,
        Position INTEGER NOT NULL,
        PRIMARY KEY (GrammarFormulaId, GrammarPartId),
        FOREIGN KEY (GrammarFormulaId) REFERENCES GrammarFormula(Id) ON DELETE CASCADE,
        FOREIGN KEY (GrammarPartId) REFERENCES GrammarPart(Id) ON DELETE CASCADE
    );",

    @"CREATE TABLE IF NOT EXISTS User_info (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Name TEXT NOT NULL
    );",

    @"CREATE TABLE IF NOT EXISTS Exam_info (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        UserId INTEGER NOT NULL,
        FOREIGN KEY (UserId) REFERENCES User_info(Id) ON DELETE CASCADE
    );"
                };

                foreach (string sql in tableQueries)
                {
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(_connectionString);
        }

        public void ResetDatabase()
        {
            Console.WriteLine("Đang xóa database...");

            try
            {
                if (File.Exists(_dbPath))
                {
                    SQLiteConnection.ClearAllPools(); // Đảm bảo không có kết nối nào đang mở
                    File.Delete(_dbPath);
                    Console.WriteLine("Database đã được xóa.");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy database để xóa.");
                }

                // Tạo lại database
                InitializeDatabase();
                Console.WriteLine("Database mới đã được tạo lại.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa database: {ex.Message}");
            }
        }


        public void TestDatabase()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                Console.WriteLine("Kết nối đến database thành công!");

                string sql = "SELECT name FROM sqlite_master WHERE type='table';";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("Các bảng trong database:");
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["name"]);
                    }
                }
            }
        }

    }
}
