using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    class Veiculo
    {
        public  string marca { get; set;}
        public  string modelo { get; set; }
        public string placa { get; set; }
        public  string cor { get; set; }
        public  int litrosCombustivel { get; set; }
        public int qtdCombustivel { get; set; }
        public  bool isligado { get; set; }
        public  int velocidade { get; set; }

        public Veiculo(string marca, string modelo, string placa, string cor, int litrosCombustivel, int qtdCombustivel, bool isligado, int velocidade)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cor = cor;
            this.litrosCombustivel = litrosCombustivel;
            this.qtdCombustivel = qtdCombustivel;
            this.isligado = isligado;
            this.velocidade = velocidade;
        }

        public Veiculo()
        {
        }

        public void acelerar()
        {
            if (isligado == true)   
            {
                this.velocidade += 20;
                this.litrosCombustivel -= 1;
                Console.WriteLine(" o  carro acelerou e sua velocidade é de :" + this.velocidade + "KM/H");
            }
            else
            {
                Console.WriteLine("voce precisa ligar o carro primeiro ");
            }


        }

        public void frear()
        { if (this.isligado == true)
            {
                if (this.velocidade > 50)

                    this.velocidade -= 10;
            }
            else
            {
                if (this.velocidade <= 0)
                {
                    Console.WriteLine("carro parado");
                }
                else
                {
                    Console.WriteLine("carro desligado");
                }
            }
            Console.WriteLine("A velocidade do carro e de :" + this.velocidade +" KM/H"); 
        }

        

        public void ligar()
        { if (isligado == false)
            {
                Console.WriteLine("ligando carro ");
                this.isligado = true;
            }
            else
            {
                Console.WriteLine("o carro ja esta ligado ");
            }

        }

        public void desligar()
        { if (isligado == true)
            {
                Console.WriteLine( " delisgando carro ");
                this.isligado = false;

            }else
            {
                Console.WriteLine("o carro ja esta desligado");
            }

        }

        public  void abastecer( int litrosCombustivel)
        { 
            if (this.litrosCombustivel + litrosCombustivel > 100)
            {
                Console.WriteLine("tanque cheio ! não exeder o limite de 100 L");
            } else
            {
                this.litrosCombustivel += this.qtdCombustivel;
                Console.WriteLine("tanque abastecido " + this.litrosCombustivel);
            }


        }


        public void exibirdados()
        {
            Console.WriteLine(" o carro esta ligado? " +this.isligado);
            Console.WriteLine("qual e a marca: " + this.marca);
            Console.WriteLine("qual é o modelo : "+ this.modelo);
            Console.WriteLine("qual é a placa:  "+ this.placa);
            Console.WriteLine("quantidade de combustivel no momento: " + this.litrosCombustivel);
            Console.WriteLine("velocidade atual: " + this.velocidade);



        }


    }
}
