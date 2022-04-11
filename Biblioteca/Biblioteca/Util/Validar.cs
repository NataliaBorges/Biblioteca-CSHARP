using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Util {
    public class Validar {
        private Validar() { }
        public static bool ValidaCpf(string cpf) {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }
        public static bool ValidarEmail(string email) {
            bool validEmail = false;
            int indexArr = email.IndexOf('@');
            if (indexArr > 0) {
                int indexDot = email.IndexOf('.', indexArr);
                if (indexDot - 1 > indexArr) {
                    if (indexDot + 1 < email.Length) {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".") {
                            validEmail = true;
                        }
                    }
                }
            }
            return validEmail;
        }
        public static bool ValidaISBN13(string isbn) {
            bool result = false;
            if (!string.IsNullOrEmpty(isbn)) {
                long j;
                if (isbn.Contains('-')) isbn = isbn.Replace("-", "");

                
                if (!Int64.TryParse(isbn, out j))
                    result = false;

                int sum = 0;
                for (int i = 0; i < 12; i++) {
                    sum += Int32.Parse(isbn[i].ToString()) * (i % 2 == 1 ? 3 : 1);
                }

                int remainder = sum % 10;
                int checkDigit = 10 - remainder;
                if (checkDigit == 10) checkDigit = 0;

                result = (checkDigit == int.Parse(isbn[12].ToString()));
            }

            return result;
        }
        public static bool ValidaIsbn10(string isbn) {
            int n = isbn.Length;
            char last = isbn[9];
            int sum = 0;

            if (n != 10) {
                return false;
            }
            
            for (int i = 0; i < 9; i++) {
                int digit = isbn[i] - '0';

                if (0 > digit || 9 < digit)
                    return false;

                sum += (digit * (10 - i));
            }

            if (last != 'X' && (last < '0' || last > '9')) {
                return false;
            }else sum += ((last == 'X') ? 10 : (last - '0'));
                return (sum % 11 == 0);
        }
    }
}
