using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
namespace DIO.Series
{
    public class SeriesRepository : IRepository<Series>
    {
        private List<Series> ListSeries = new List<Series>();
        public void Delete(int Id)
        {
            ListSeries[Id].Delete();
        }

        public void Insert(Series entity)
        {
            ListSeries.Add(entity);
        }

        public List<Series> GetList()
        {
            return ListSeries;
        }

        public int nextId()
        {
            return ListSeries.Count;
        }

        public Series ReturnById(int Id)
        {
            return ListSeries[Id];
        }

        public void Update(int Id, Series entity)
        {
            ListSeries[Id] = entity;
        }
    }
}