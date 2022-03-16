using System;

namespace DIO.Series
{
    public class Series : AEntityBase
    {
        private Genres Genre { get; set; }

        private string Title { get; set; }

        private string Description { get; set; } 
        private int Year { get; set; }

        private bool Deleted { get; set; }

        public Series (int id, Genres genre, string title, string description, int year)
        {

            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }

        public void Delete()
        {
            this.Deleted = true;
        }
        public string getId()
        {
            return this.Id.ToString();
        }

        public bool getDelete()
        {
            return this.Deleted;
        }

        public string getTitle()
        {
            return this.Title;
        }
        public override string ToString()
        {
            string text = "";
            text += $"Genre: {this.Genre}{Environment.NewLine}";
            text += $"Title: {this.Title}{Environment.NewLine}";
            text += $"Description: {this.Description}{Environment.NewLine}";
            text += $"Year: {this.Year}{Environment.NewLine}";
            text += $"Deleted: {this.Deleted}{Environment.NewLine}";
            return text;
        }
    }
}