/* 
Desarrolla un algoritmo para solucionar uno de los siguientes casos Cifrado Atbac e
implementalo en una clase de extensión de C#. Recuerda que lo único que se proporciona a tu tester
es el archivo del ejercicio (archivo de C# en este caso). El tester subirá a plataforma
evidencia gráfica de su revisión (capturas de pantalla) + la hoja de evaluación contenida en el
presente documento. Agrega a la clase string, mediante una clase estática de extensión, un método de cifrado que permita
codificar/decodificar el contenido de la misma. Desarrolla un programa que permita la introducción de
cadenas por parte del usuario y a continuación se muestre la misma codificada. El programa se
repetirá hasta que 
*/
using System;
using System.IO;

class String{
    public char letra;
    public String(char letra){
        this.letra = letra;
    }
    public  void Codificar(){
        char[] abc = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] abc2 = "zyxwvutsrqponmlkjihgfedcba".ToCharArray();
        for(int i = 0; i < abc.Length; i++){
            if(this.letra == abc[i]){
                this.letra = abc2[i];
                break;
            }
        }
    }
}

class program{
    static void Main(string[] args){
        string cadena = "";
        Console.WriteLine("Bienvenido al programa de codificacion Atbac");
        do{
            Console.WriteLine("Introduce una cadena de texto , escribe salir si desea salir del programa: ");
            try{
                cadena = Console.ReadLine();
            }catch(Exception e){
                Console.WriteLine("Error: " + e.Message);
            }
            char[] letras = cadena.ToCharArray();
            for(int i = 0; i < letras.Length; i++){
                String letra = new String(letras[i]);
                letra.Codificar();
                Console.Write(letra.letra);
            }
            Console.WriteLine();
        }while(cadena != "salir");
        Console.WriteLine("Gracias por usar el programa de codificacion Atbac");
    }
}