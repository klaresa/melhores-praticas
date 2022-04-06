using System;
using System.Collections.Generic;
using System.Text;

namespace TP3Alunos.Domain.ValueObject
{
    public class Matricula
    {
        public Matricula() {}

        public Matricula(string valor)
        {
            this.Valor = valor?.Replace(".", "").Replace("-", "") ?? throw new ArgumentNullException(nameof(Matricula));
        }

        public string Valor { get; set; }
        public string Formatado => ValorFormatado(this.Valor);

        private string ValorFormatado(string valor) => Convert.ToInt64(valor).ToString(@"000\.000\.000\-00");
    }
}
