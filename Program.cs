using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cl1
{

   public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<LogEntry> LogEntries { get; set; }
    }

    public class LogEntry
    {
        public int Id { get; set; }
        public DateTime When { get; set; }
        public string Text { get; set; }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlite("Filename=./Log.db");
            DataContext context = new DataContext(optionsBuilder.Options);
            WriteLogEntry(context);
            DumpLog(context);
        }
        
        protected static void WriteLogEntry(DataContext context) {
            LogEntry entry = new LogEntry();
            entry.When = DateTime.Now;
            entry.Text = "Program started.";
            context.LogEntries.Add(entry);
            context.SaveChanges();
        }
        
        protected static void DumpLog(DataContext context) {
            List<LogEntry> log = context.LogEntries.ToList();
            foreach (var entry in log)
            {
                Console.WriteLine("{0}: {1}", entry.When.ToString(), entry.Text);
            }
        }
    }
}
