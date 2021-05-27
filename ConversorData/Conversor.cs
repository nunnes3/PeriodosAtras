using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorData
{
    public class Conversor
    {
        private DateTime dataCompara = new DateTime(2021, 05, 26, 15, 35, 30);
        private int calculoSegundos = 0;
        private string resultadoConsulta = String.Empty;


        List<string> dicionarioNumeros = new List<string>
            {
               "Um","Dois","Três","Quatro","Cinco","Seis","Sete","Oito","Nove","Dez","Onze","Doze","Treze","Quatorze","Quinze","Dezesseis",
               "Dezessete","Dezoito","Dezenove","Vinte","Vinte e um","Vinte e dois","Vinte e três","Vinte e quatro","Vinte e cinco","Vinte e Seis",
               "Vinte e oito","Vinte e nove","Trinta","Trinta e um","Trinta e dois","Trinta e tres","Trinta e quatro", "Trinta e cinco", "Trinta e seis",
               "Trinta e sete", "Trinta e oito", "Trinta e nove","Quarenta","Quarenta e um","Quarenta e dois","Quarenta e três","Quarenta e quatro","Quarenta e cinco",
               "Quarenta e seis","Quarenta e sete","Quarenta e oito","Quarenta e nove","Cinquenta","Cinquenta e um","Cinquenta e dois","Cinquenta e três",
               "Cinquenta e quatro","Cinquenta e cinco","Cinquenta e seis","Cinquenta e sete","Cinquenta e oito","Cinquenta e nove","Sessenta","Sessenta e um",
               "Sessenta e dois","Sessenta e três","Sessenta e quatro","Sessenta e cinco","Sessenta e seis","Sessenta e sete","Sessenta e oito","Sessenta e nove",
               "Setenta","Sententa e um","Sententa e dois","Sententa e três","Sententa e quatro","Setenta e cinco","Setenta e seis","Setenta e sete","Sententa e oito","Setenta e nove",
               "Oitenta","Oitenta e um","Oitenta e dois","Oitenta e três","Oitenta e quatro","Oitenta e cinco","Oitenta e seis","Oitenta e sete","Oitenta e oito","Oitenta e nove",
               "Noventa","Noventa e um","Noventa e dois","Noventa e três","Noventa e quatro","Noventa e cinco","Noventa e seis","Noventa e sete","Noventa e oito","Noventa e nove"
            };



        public string ValidarData(DateTime data)
        {

            if (data > dataCompara)
            {
                return "Data inválida";
            }

            validarSegundoHoraMinuto(data);
            validaDiasSemanas(data);
            validaMes(data);
            validadeAno(data);

            return resultadoConsulta;
        }

        private string validarSegundoHoraMinuto(DateTime data)
        {

            if (data.Day == dataCompara.Day && data.Month == dataCompara.Month && data.Year == dataCompara.Year)
            {
                if (data.Second != dataCompara.Second && data.Hour == dataCompara.Hour && data.Minute == dataCompara.Minute)
                {

                    calculoSegundos = dataCompara.Second - data.Second;


                    for (int i = 0; i < dicionarioNumeros.Count; i++)
                    {
                        if (calculoSegundos == i && calculoSegundos != 1)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " segundos atrás";
                        }
                        else if (calculoSegundos == 1)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " segundo atrás";
                        }
                    }
                }

                else if (data.Hour == dataCompara.Hour && data.Minute != dataCompara.Minute)
                {
                    int calculoMinutos = dataCompara.Minute - data.Minute;


                    for (int i = 0; i < dicionarioNumeros.Count; i++)
                    {
                        if (calculoMinutos == i && calculoMinutos != 1)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " minutos atrás";
                        }
                        else if (calculoMinutos == 1)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " minuto atrás";
                        }

                    }

                }
                else if (data.Hour != dataCompara.Hour)
                {
                    int calculoHoras = dataCompara.Hour - data.Hour;


                    for (int i = 0; i < dicionarioNumeros.Count; i++)
                    {
                        if (calculoHoras == i && calculoHoras != 1)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " horas atrás";

                        }
                        else if (calculoHoras == 1)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " hora atrás";
                        }

                    }
                }
            }

            return resultadoConsulta;

        }

        private string validaDiasSemanas(DateTime data)
        {
            int calculoDias = dataCompara.Day - data.Day;

            if (data.Day < dataCompara.Day && data.Month == dataCompara.Month && data.Year == dataCompara.Year && calculoDias < 7)
            {
                for (int i = 0; i < dicionarioNumeros.Count; i++)
                {
                    if (calculoDias == i && calculoDias != 1)
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " dias atrás";
                    }
                    else if (calculoDias == 1 && calculoDias == i)
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " dia atrás";
                    }
                }
            }
            else if (calculoDias >= 7 && data.Year == dataCompara.Year)
            {
                int calculoSemanas = calculoDias / 7;

                for (int i = 0; i < dicionarioNumeros.Count; i++)
                {
                    if (calculoSemanas == i && calculoSemanas != 1 && calculoSemanas != 2)
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " semanas atrás";
                    }
                    else if (calculoSemanas == 1 && calculoSemanas == i)
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + "a" + " semana atrás";
                    }
                    else if (calculoSemanas == i && calculoSemanas == 2)
                    {
                        return resultadoConsulta = "Duas semanas atrás";
                    }
                }
            }
            else if (data.Month != dataCompara.Month && data.Year == dataCompara.Year && calculoDias < 7)
            {
                if (data.Day > dataCompara.Day)
                {
                    calculoDias = data.Day - dataCompara.Day;

                    for (int i = 0; i < dicionarioNumeros.Count; i++)
                    {
                        if (calculoDias == i && calculoDias != 1)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " dias atrás";
                        }
                        else if (calculoDias == 1 && calculoDias == i)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " dia atrás";
                        }
                    }

                }
                else if (dataCompara.Day > data.Day)
                {
                    calculoDias = dataCompara.Day - data.Day;

                    for (int i = 0; i < dicionarioNumeros.Count; i++)
                    {
                        if (calculoDias == i && calculoDias != 1)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " dias atrás";
                        }
                        else if (calculoDias == 1 && calculoDias == i)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " dia atrás";
                        }
                    }

                }
                else
                {
                    return resultadoConsulta = "0";
                }

            }

            return resultadoConsulta;
        }

        private string validaMes(DateTime data)
        {
            string recebeDiasSemanas = validaDiasSemanas(data);
            int calculoMes = dataCompara.Month - data.Month;
            if (data.Month != dataCompara.Month && data.Year == dataCompara.Year)
            {


                for (int i = 0; i < dicionarioNumeros.Count; i++)
                {

                    if (calculoMes == i && calculoMes != 1 && recebeDiasSemanas == "0")
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " meses";
                    }
                    else if (calculoMes == 1 && calculoMes == i && recebeDiasSemanas == "0")
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " mês";
                    }

                    if (calculoMes == i && calculoMes != 1 && recebeDiasSemanas != "0")
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " meses e " + recebeDiasSemanas.ToLower();

                    }
                    else if (calculoMes == i && calculoMes == 1 && recebeDiasSemanas != "0")
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " mês e " + recebeDiasSemanas.ToLower();
                    }
                }

            }
            else if (data.Year != dataCompara.Year)
            {
                int subDataRecebida = 12 - data.Month;
                int adMeses = subDataRecebida + dataCompara.Month;
                int divideMeses = adMeses % 12;

                if (divideMeses != 0)
                {

                    for (int i = 0; i < dicionarioNumeros.Count; i++)
                    {
                        if (divideMeses == i && divideMeses != 1 && divideMeses != 0)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " meses atrás";
                        }
                        else if (divideMeses == 1 && divideMeses == i && divideMeses != 0)
                        {
                            return resultadoConsulta = dicionarioNumeros[i - 1] + " mês atrás";
                        }

                    }
                }
                else
                {
                    return resultadoConsulta = "0";
                }

            }
            return resultadoConsulta;
        }

        private string validadeAno(DateTime data)
        {

            string recebeConsulta = validaMes(data);

            if (data.Year != dataCompara.Year)
            {
                int calculoData = dataCompara.Year - data.Year;
                for (int i = 0; i < dicionarioNumeros.Count; i++)
                {

                    if (calculoData == i && calculoData != 1 && recebeConsulta != "0")
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " anos e" + recebeConsulta.ToLower();
                    }
                    else if (calculoData == 1 && calculoData == i && recebeConsulta != "0")
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " ano e "  + recebeConsulta.ToLower();
                    }
                    else if (calculoData == 1 && calculoData == i && recebeConsulta == "0")
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " ano atrás";

                    }
                    else if (calculoData == i && calculoData == i && recebeConsulta == "0")
                    {
                        return resultadoConsulta = dicionarioNumeros[i - 1] + " anos atrás";
                    }
                }
            }

            return resultadoConsulta;
        }

    }
}
                
                    
                
    



                    
                  