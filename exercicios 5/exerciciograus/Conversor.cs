public class Conversor{
    
    public void CelsiusToFahrenheit(double valor){
        double f;
        f=valor*1.8+32;
        Console.WriteLine("Ao converter "+valor+"°C para fahrenheit, temos "+f+"°F!");
    }
    public void FahrenheitToCelsius(double valor){
        double c;
        c=(valor-32)/1.8;
        Console.WriteLine("Ao converter "+valor+"°F para celsius, temos "+c+"°C!");
    }
}