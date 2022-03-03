using DIO_Series.Interfaces;
using System;
using System.Collections.Generic;


namespace DIO_Series
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();

        public void Delet(int id)
        {
            try
            {
                listSerie[id].DeletedSerie();
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new ArgumentException("Index is out of range", nameof(id), ex);
            }
        }

        public void Insert(Serie entity)
        {
            listSerie.Add(entity);
        }

        public List<Serie> List()
        {
            return listSerie;
        }

        public int NextId()
        {
            return listSerie.Count;
        }

        public Serie ReturnForId(int id)
        {
            try
            {
                return listSerie[id];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new ArgumentException("Index is out of range", nameof(id), ex);
            }

        }

        public void Update(int id, Serie entity)
        {
            listSerie[id] = entity;
        }
    }
}
