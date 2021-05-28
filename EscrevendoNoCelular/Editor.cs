using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular
{
    public class Editor
    {
        
        public string Digitar(string msg)
        {
            
            string codigo = "";
            for (int i = 0; i < msg.Length; i++)
            {
                if (i != 0)
                {
                    codigo += "_" + Codifica(msg[i]);
                }
                else
                {
                    codigo += "" + Codifica(msg[i]);
                }

            }
            return codigo;
        }

        private string Codifica(char letra)
        {
            switch (letra.ToString())
            {
                case "_":
                    return "0";
                    break;

                case "A":
                    return "2";
                    break;

                case "B":
                    return "22";
                    break;

                case "C":
                    return "222";
                    break;

                case "D":
                    return "3";
                    break;

                case "E":
                    return "33";
                    break;

                case "F":
                    return "333";
                    break;

                case "G":
                    return "4";
                    break;

                case "H":
                    return "44";
                    break;

                case "I":
                    return "444";
                    break;

                case "J":
                    return "5";
                    break;

                case "K":
                    return "55";
                    break;

                case "L":
                    return "555";
                    break;

                case "M":
                    return "6";
                    break;

                case "N":
                    return "66";
                    break;

                case "O":
                    return "666";
                    break;

                case "P":
                    return "7";
                    break;

                case "Q":
                    return "77";
                    break;

                case "R":
                    return "777";
                    break;

                case "S":
                    return "7777";
                    break;

                case "T":
                    return "8";
                    break;

                case "U":
                    return "88";
                    break;

                case "V":
                    return "888";
                    break;

                case "W":
                    return "9";
                    break;

                case "X":
                    return "99";
                    break;

                case "Y":
                    return "999";
                    break;

                case "Z":
                    return "9999";
                    break;

              


















                default:
                    return "";
            }
        }
    }
}