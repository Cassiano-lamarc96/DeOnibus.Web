using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeOnibus.Models
{
    public class RetornoServicoViagem
    {
        public RetornoServicoViagem()
        {
            results = new List<ServicoViagem>();
        }

        public List<ServicoViagem> results { get; set; }
    }

    public class ServicoViagem
    {
        public ServicoViagem()
        {
            Company = new Company();
            DepartureDate = new DepartureDate();
            ArrivalDate = new ArrivalDate();
        }

        public string objectId { get; set; }
        public Company Company { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DepartureDate DepartureDate { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public decimal Price { get; set; }
        public string BusClass { get; set; }
        public ArrivalDate ArrivalDate { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }
    }

    public class DepartureDate
    {
        public string __type { get; set; }
        public DateTime iso { get; set; }
    }

    public class ArrivalDate
    {
        public string __type { get; set; }
        public DateTime iso { get; set; }
    }
}