using System;
using DIO_Series.Enum;

namespace DIO_Series
{
    public class Serie : EntityBase
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Deleted { get; set; }

        public Serie(int id, Genre genre, string title, string description, int year)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Description = description;
            Year = year;
            Deleted = false;
        }

        public Serie()
        {
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genre + Environment.NewLine;
            retorno += "Titulo: " + Title + Environment.NewLine;
            retorno += "Descrição: " + Description + Environment.NewLine;
            retorno += "Ano de Ínicio: " + Year;
            return retorno;
        }
        public string returnTitle()
        {
            return Title;
        }
        public int returnId()
        {
            return Id;
        }
        public bool returnDeleted()
        {
            return this.Deleted;
        }
        public void DeletedSerie()
        {
            Deleted = true;
        }
    }
}
