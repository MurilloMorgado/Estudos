using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.aulas.aula42
{
    internal class Aluno
    {
        public string? Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado(double notaFinal)
        {
            if (notaFinal > 60)
            {
                return true;
            }
            return false;
        }
    
        public double NotaRestante()
        {
            return 60 - NotaFinal(); 
        }
    }
}
