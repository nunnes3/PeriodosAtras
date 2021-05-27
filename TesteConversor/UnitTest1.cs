using ConversorData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteConversor
{
    [TestClass]
    public class TesteConversor
    {
        DateTime dateTimeSegundos = new DateTime(2021, 05, 26, 15, 35, 20);
        DateTime dateTimeMinutos = new DateTime(2021, 05, 26, 15, 32, 45);
        DateTime dateHoras = new DateTime(2021, 05, 26, 11, 32, 45);
        DateTime dataInvalida = new DateTime(2021, 05, 27, 15, 35, 20);
        DateTime dataDias = new DateTime(2021, 05, 25, 15, 35, 20);
        DateTime dataDoisDias = new DateTime(2021, 05, 24, 15, 35, 20);
        DateTime dataUmaSemana = new DateTime(2021, 05, 19, 15, 35, 20);
        DateTime dataDuasSemanas = new DateTime(2021, 05, 12, 15, 35, 20);
        DateTime dataUmMes = new DateTime(2021, 04, 19, 15, 35, 20);
        DateTime dataUmEDoisDias = new DateTime(2021, 04, 24, 15, 35, 20);
        DateTime dataDoisEDoisDias = new DateTime(2021, 03, 24, 15, 35, 20);
        DateTime dataUmAnoEUmMesdiferenca = new DateTime(2020, 04, 26, 15, 35, 20);
        DateTime dataUmAnodiferenca = new DateTime(2020, 05, 26, 15, 35, 20);
        [TestMethod]
        public void retornaInvalido()
        {

           Assert.AreEqual("Data inválida", new Conversor().ValidarData(dataInvalida));
        }

        [TestMethod] 
        public void retornaSegundos()
        {
            

            Assert.AreEqual("Dez segundos atrás", new Conversor().ValidarData(dateTimeSegundos)) ;

        }

        [TestMethod]
        public void retornaMinutos()
        {

            Assert.AreEqual("Três minutos atrás", new Conversor().ValidarData(dateTimeMinutos));

        }

        [TestMethod]
        public void retornaHoras()
        {

            Assert.AreEqual("Quatro horas atrás", new Conversor().ValidarData(dateHoras));

        }

        [TestMethod]
        public void retornaUmDia()
        {

            Assert.AreEqual("Um dia atrás", new Conversor().ValidarData(dataDias));

        }

        [TestMethod]
        public void retornaDoisDias()
        {

            Assert.AreEqual("Dois dias atrás", new Conversor().ValidarData(dataDoisDias));

        }
        [TestMethod]
        public void retornaUmaSemana()
        {

            Assert.AreEqual("Uma semana atrás", new Conversor().ValidarData(dataUmaSemana));

        }
        [TestMethod]
        public void retornaDuasSemanas()
        {

            Assert.AreEqual("Duas semanas atrás", new Conversor().ValidarData(dataDuasSemanas));

        }
        [TestMethod]
        public void retornaUmMesEUmaSemana()
        {

            Assert.AreEqual("Um mês e uma semana atrás", new Conversor().ValidarData(dataUmMes));

        }

        [TestMethod]
        public void retornaUmMesEDoisDias()
        {

            Assert.AreEqual("Um mês e dois dias atrás", new Conversor().ValidarData(dataUmEDoisDias));

        }
        [TestMethod]
        public void retornaDoisMesesEDoisDias()
        {

            Assert.AreEqual("Dois meses e dois dias atrás", new Conversor().ValidarData(dataDoisEDoisDias));

        }

        [TestMethod]
        public void retornaUmAnoMes()
        {

            Assert.AreEqual("Um ano e um mês atrás", new Conversor().ValidarData(dataUmAnoEUmMesdiferenca));

        }

        [TestMethod]
        public void retornaUmAno()
        {

            Assert.AreEqual("Um ano atrás", new Conversor().ValidarData(dataUmAnodiferenca));

        }
    }
}
