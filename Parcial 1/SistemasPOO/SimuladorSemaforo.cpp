/*******************************************************************
Fecha de creacion: 19/09/2022
Fecha de ultima actualizacion: 21/09/2022
Nombre del programador: Marcos Damian Pool Canul
Nombre del programa: Menu con varios juegos
Descripcion:
Entradas:
Salidas:
*******************************************************************/

#include <iostream>
#include <stdio.h>
#include <string.h>

using namespace std;

void Semaforo();
void Vibora();
void JuegoGato();
void CocheSemaforo();

int main()
{
    int opt = 0;
    do
    {
        cout << "\nBienvenido al Menu \n"
             << endl;
        cout << "1. Semaforo" << endl;
        cout << "2. Vibora" << endl;
        cout << "3. Juego Gato" << endl;
        cout << "4. Coche Semaforo" << endl;
        cout << "5. Exit" << endl;
        cout << "\n> Opcion: ";

        cin >> opt;

        switch (opt)
        {
        case 1:
            Semaforo();
            break;
        case 2:
            Vibora();
            break;
        case 3:
            JuegoGato();
            break;
        case 4:
            CocheSemaforo();
            break;
        default:
            cout << "\n--- Ingrese una opcion valida ---\n"
                 << endl;
        }

    } while (opt != 5);

    return 0;
}

void Semaforo()
{
    int Color = 0;
    string Luz1 = "Verde";
    string Luz2 = "Naranja";
    string Luz3 = "Roja";

    cout << "\nSemaforo actual\n"
         << endl;
    cout << "[-] " << Luz1 << endl;
    cout << "[-] " << Luz2 << endl;
    cout << "[-] " << Luz3 << endl;

    do
    {
        cout << "\nVerde = 1, Naranja = 2, Roja = 3, Salir = 4" << endl;
        cout << "\n> Ingrese la luz a activar: ";
        cin >> Color;

        switch (Color)
        {
        case 1:
            cout << endl;
            cout << "[*] " << Luz1 << endl;
            cout << "[-] " << Luz2 << endl;
            cout << "[-] " << Luz3 << endl;
            for (int i = 1; i <= 60; i++)
            {
                system("color 20");
            }

            for (int i = 1; i <= 50; i++)
            {
                system("color E0");
            }

            for (int i = 1; i < 50; i++)
            {
                system("color C0");
            }
            system("color 07");
            break;
        case 2:
            cout << endl;
            cout << "[-] " << Luz1 << endl;
            cout << "[*] " << Luz2 << endl;
            cout << "[-] " << Luz3 << endl;
            for (int i = 1; i <= 30; i++)
            {
                system("color E0");
            }

            for (int i = 1; i < 50; i++)
            {
                system("color C0");
            }

            for (int i = 1; i <= 50; i++)
            {
                system("color 20");
            }

            system("color 07");
            break;
        case 3:
            cout << endl;
            cout << "[-] " << Luz1 << endl;
            cout << "[-] " << Luz2 << endl;
            cout << "[*] " << Luz3 << endl;
            for (int i = 1; i < 50; i++)
            {
                system("color C0");
            }

            for (int i = 1; i <= 50; i++)
            {
                system("color E0");
            }

            for (int i = 1; i <= 60; i++)
            {
                system("color 20");
            }

            system("color 07");
            break;
        default:
            cout << "\nIngrese una opcion valida\n";
            break;
        }
    } while (Color != 4);
}

void Vibora()
{
    cout << "\n--- Juego de la Vibora ---\n"
         << endl;
}

void JuegoGato()
{
    cout << "\n--- Juego del Gato ---\n"
         << endl;
}

void CocheSemaforo()
{
    cout << "\n--- Juego del Coche Semaforo---\n"
         << endl;
}