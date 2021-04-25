using System;
using System.Collections.Generic;
using System.Text;
using Contratos.Entities.Enums;

namespace Contratos.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string nome, WorkerLevel level, double baseSalary, Department department)
        {
            Name = nome;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addContracts(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContracts(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contracts in Contracts)
            {
                if (contracts.Date.Year.Equals(year) && contracts.Date.Month.Equals(month))
                {
                    sum += contracts.totalValue();
                }
            }
            return sum;
        }

    }
}
