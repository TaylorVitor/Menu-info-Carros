using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_de_escolha
{
    class Program
    {
        enum car {Celta = 1, Amarok, Veloster, Gol, Astra, C4}

        static void Main(string[] args)
        {
            Console.WriteLine("Descubra as informações técnicas do veiculo! \n");
            Console.WriteLine("1 - Celta \n2 - Amarok \n3 - Veloster \n4 - Gol \n5 - Astra \n6 - C4 \n");
            int selectCar = int.Parse(Console.ReadLine());
            car myCar = (car)selectCar;
            Console.WriteLine(myCar + "\n");

            if(selectCar == 1)
            {
                Console.WriteLine("MOTOR 1.0 \nPORTAS 4 \nRÁDIO \nDESEMBAÇADOR TRASEIRO \nLIMPADOR TRASEIRO \nPAINEL DIGITAL \nTRAVA ELÉTRICA");

            } else if(selectCar == 2)
            {
                Console.WriteLine("MOTOR 3.0 V6 \nPORTAS 4 \nControle de tração \nSensor de estacionamento \nCâmera de Ré Banco com ajuste elétrico \nControle de Estabilidade \nDireção hidráulica \nAr condicionado \nVidros elétricos dianteiro ");

            } else if(selectCar == 3)
            {
                Console.WriteLine("MOTOR 1.6 \nPORTAS 3 \nALARME ALARME \nAR CONDICIONADO \nAIR BAG \nBANCO DE COURO \nCÂMBIO  \nDIREÇÃO HIDRÁULICA \nFREIO ABS \nPAINEL DIGITAL \nRETROVISOR ELÉTRICO \nTETO SOLAR \nTRAVA ELÉTRICA");

            } else if(selectCar == 4)
            {
                Console.WriteLine("MOTOR 1.0 \nPORTAS 4 \nAR CONDICIONADO \nDIREÇÃO HIDRÁULICA \nTRAVA ELÉTRICA \nVIDRO ELÉTRICO");

            } else if(selectCar == 5)
            {
                Console.WriteLine("MOTOR 2.0 MFI \nPORTAS 2 \nALARME \nAR CONDICIONADO \nDESEMBAÇADOR TRASEIRO \nLIMPADOR TRASEIRO \nDIREÇÃO HIDRÁULICA \nTRAVA ELÉTRICA \nVIDRO ELÉTRICO \nAR QUENTE");

            } else if(selectCar == 6)
            {
                Console.WriteLine("MOTOR 1.6 GLX \nPORTAS 4 \nAR CONDICIONADO \nDIREÇÃO HIDRÁULICA \nTRAVA ELÉTRICA \nVIDRO ELÉTRICO");

            } else
            {
                Console.WriteLine("Veiculo não encontrado");
            }

            Console.ReadLine();

        }
    }
}
