using Microsoft.AspNetCore.Mvc;

namespace EjercicioS4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("calculararea")]
        public string calculararea()
        {
            int largo = 5;
            int ancho = 3;
            int area = largo * ancho;
            string mensaje = "El área del rectangulo es: " + area + " metros cuadrados";
            return mensaje;
        }



        [HttpGet("CalcularEdad/{nombre}/{edad}")]
        public string CalcularEdad(string nombre, int edad)
        {
            int anioActual = 2024;
            int edadResultado = anioActual - edad;
            string mensaje = "Señor " + nombre + " su edad es " + edadResultado;
            return mensaje;
        }



        [HttpGet("CalcularGeneracion/{anioNacimiento}/{nombre}")]
        public string CalcularGeneracion(int anioNacimiento, string nombre)
        {
            int anio = 2024;
            int resultado = anio - anioNacimiento;
            if (resultado >= 18 && resultado <= 20)
            {
                return "Señor " + nombre + " usted es de la generacion Z ";
            }
            else
            {
                return "Usted no pertenece a la generacion Z";
            }
        }
    }
}
