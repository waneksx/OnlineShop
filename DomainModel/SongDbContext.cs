namespace DomainModel
{
    using Entities;
    using Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SongDbContext : DbContext
    {
        // Контекст настроен для использования строки подключения "Model1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "DomainModel.Model1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model1" 
        // в файле конфигурации приложения.
        public SongDbContext()
            : base("name=SongDbContext")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<SongDbContext, Configuration>());
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Song> Songs { get; set; }
    }

    
}