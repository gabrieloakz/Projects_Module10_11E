using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI_PARENT
{
    public class Categorias
    {
        private int codigo;
        private string categoria;
        private string zona;
        private int fila;
        private int prateleira;

        //construtor vazio
        public Categorias() 
        { 
            this.codigo = 0;
            this.categoria = null;
            this.zona = null;
            this.fila = 0;
            this.prateleira = 0;
        }

        //construtor de facto
        public Categorias(int codigo, string categoria, string zona, int fila, int prateleira) 
        { 
            this.codigo = codigo;
            this.categoria = categoria;
            this.zona = zona;
            this.fila = fila;
            this.prateleira = prateleira;
        }

        //Seletores

        public int getCodigo() { return codigo; }

        public string getCategoria() {  return categoria; }

        public string getZona() {  return zona; }

        public int getFila() {  return fila; }

        public int getPrateleira() {  return prateleira; }

        //Modificadores

        public void setCodigo(int codigo) {  this.codigo = codigo; }

        public void setCategoria(string categoria) { this.categoria = categoria; }

        public void setZona(string zona) { this.zona = zona; }

        public void setFila(int fila) { this.fila = fila; }

        public void setPrateleira(int prateleira) { this.prateleira = prateleira; }
    }
}
