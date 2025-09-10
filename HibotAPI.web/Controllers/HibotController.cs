using HibotAPI.web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HibotAPI.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HibotController : ControllerBase
    {
        private readonly sg368newContext _eurekaContext;

        public HibotController(sg368newContext context)
        {
            _eurekaContext = context;
        }

        [HttpGet("ConfirmarOpHoy/{Documento}")]
        public async Task<IActionResult> GetConfirmarOpHoy(string? Documento)
        {
            if (Documento == null)
            {
                return BadRequest();
            }

            DateTime utcStart = DateTime.UtcNow.Date.ToUniversalTime();
            DateTime utcEnd = DateTime.UtcNow.Date.AddDays(1).AddTicks(-1).ToUniversalTime();

            //DateTime utcStart = DateTime.Now.Date.AddDays(1).ToUniversalTime();
            //DateTime utcEnd = DateTime.Now.Date.AddDays(250).AddTicks(-1).ToUniversalTime();

            var estadoServicioIds = new List<int> { 3, 4, 7, 8, 9, 21, 22, 23 };

            var services = await _eurekaContext.ServiciosServicios
            .Include(c => c.EstadoServicio)
            .Include(c => c.Origen)
            .Include(c => c.Conductor)
                .ThenInclude(s => s.Usuario)
            .Include(c => c.TipoProcedimiento)
            .Include(s => s.Pasajero)
                .ThenInclude(p => p.Cliente)
            .Include(s => s.Pasajero)
                .ThenInclude(p => p.CategoriaPasajero)
            .Include(s => s.Pasajero)
                .ThenInclude(p => p.TipoDocumento)
            .Include(d => d.Destino)
                .ThenInclude(d => d.Barrio)
                    .ThenInclude(d => d.Upz)
                        .ThenInclude(d => d.Localidad)
                            .ThenInclude(d => d.Ciudad)
                                .ThenInclude(d => d.Departamento)
                                    .ThenInclude(d => d.Pais)
            .Where(x => x.Pasajero.NumeroDocumento == Documento && 
                       (x.FechaServicio > utcStart && x.FechaServicio < utcEnd) &&
                        estadoServicioIds.Contains(x.EstadoServicioId) )
            .OrderBy(x => x.HoraRecogida) // Ordenar por HoraRecogida en orden descendente
            .Select(x => new
            {
                x,
                id_servicio = x.Id,
                fecha_recogida = x.HoraRecogida.ToString("yyyy-MM-dd"),
                hora_recogida = x.HoraRecogida.ToString("HH:mm"),
                hora_recogida_20 = x.HoraRecogida.AddMinutes(20).ToString("HH:mm"),
                fecha_servicio = x.FechaServicio.ToString("yyyy-MM-dd"),
                hora_servicio = x.FechaServicio.ToString("HH:mm"),
                origen_ciud = x.Origen.Barrio.Upz.Localidad.Ciudad.Nombre,
                origen_dir = x.Origen.Direccion,
                origen = x.Origen.Nombre,
                destino_ciud = x.Destino.Barrio.Upz.Localidad.Ciudad.Nombre,
                destino_dir = x.Destino.Direccion,
                destino = x.Destino.Nombre,
                operador_nombre = x.Conductor.Usuario.FirstName + " " + x.Conductor.Usuario.LastName,
                operador_placa = x.Conductor.Vehiculo.Placa,
                operador_telefono = x.Conductor.Telefono,
                estado = x.EstadoServicio.Nombre,
                estado_id = x.EstadoServicioId,
                hora_dateTime = x.HoraRecogida
            })
            .ToListAsync();

            if (!services.Any())
            {
                return NotFound();
            }

            bool isDelegate = false;

            var MensajeFinal = $"";
            foreach (var serviceDB in services)
            {
                switch (serviceDB.estado_id)
                {
                    case 23:
                        MensajeFinal += "ID: " + serviceDB.id_servicio +
                                " Recogida el día " + serviceDB.fecha_recogida +
                                " entre las " + serviceDB.hora_recogida + " y las " + serviceDB.hora_recogida_20 +
                                ", Origen: " + serviceDB.origen_ciud + " - " + serviceDB.origen + " - " + serviceDB.origen_dir +
                                ", llegada a su destino el " + serviceDB.fecha_servicio + " a las " + serviceDB.hora_servicio +
                                " en " + serviceDB.destino_ciud + " - " + serviceDB.destino + " - " + serviceDB.destino_dir +
                                ". El operador asignado es " + serviceDB.operador_nombre +
                                ", vehículo de Placa " + serviceDB.operador_placa +
                                $", número de contacto " + serviceDB.operador_telefono + "." + $" \n\n "; // Agrega un salto de línea después de cada registro

                        break;


                    default:
                        if ((serviceDB.hora_dateTime.TimeOfDay - DateTime.Now.Date.ToUniversalTime().TimeOfDay) < TimeSpan.FromHours(2) &&
                                (serviceDB.hora_dateTime.TimeOfDay - DateTime.Now.Date.ToUniversalTime().TimeOfDay) > TimeSpan.Zero)
                        {
                            MensajeFinal += "ID: " + serviceDB.id_servicio +
                                    " Recogida el día " + serviceDB.fecha_recogida +
                                    " entre las " + serviceDB.hora_recogida + " y las " + serviceDB.hora_recogida_20 +
                                    ", Origen: " + serviceDB.origen_ciud + " - " + serviceDB.origen + " - " + serviceDB.origen_dir +
                                    ", llegada a su destino el " + serviceDB.fecha_servicio + " a las " + serviceDB.hora_servicio +
                                    $" en " + serviceDB.destino_ciud + " - " + serviceDB.destino + " - " + serviceDB.destino_dir + $" \n\n";
                            isDelegate = true;
                            break;
                        }
                        else if ((serviceDB.hora_dateTime.TimeOfDay - DateTime.Now.Date.ToUniversalTime().TimeOfDay) > TimeSpan.FromHours(2))
                        {
                            MensajeFinal += "ID: " + serviceDB.id_servicio +
                                    " Recogida el día " + serviceDB.fecha_recogida +
                                    " entre las " + serviceDB.hora_recogida + " y las " + serviceDB.hora_recogida_20 +
                                    ", Origen: " + serviceDB.origen_ciud + " - " + serviceDB.origen + " - " + serviceDB.origen_dir +
                                    ", llegada a su destino el " + serviceDB.fecha_servicio + " a las " + serviceDB.hora_servicio +
                                    " en " + serviceDB.destino_ciud + " - " + serviceDB.destino + " - " + serviceDB.destino_dir +
                                    ". El operador asignado se le estará informando a más tardar 2 horas antes de la prestación" +
                                    " del servicio, en caso de presentarse alguna novedad con la información sobre su servicio" +
                                    " indíquela por este medio para su respectiva gestión, en caso de no tener ninguna novedad" +
                                    $" por favor no responda este mensaje" + $" \n\n";
                            

                            break;
                        }
                        else
                        {
                            break;
                        }

                }
            }

            Mensaje MsgToReturn = new Mensaje()
            {
                Detalle = MensajeFinal
            };

            if (isDelegate)
            {
                MsgToReturn.Accion = "DELEGAR";
            }
            else
            {
                MsgToReturn.Accion = "INFORMAR";

            }
            Console.WriteLine(MsgToReturn);
            return Ok(MsgToReturn);

        }

        [HttpGet("ConfirmarOpMañana/{Documento}")]
        public async Task<IActionResult> GetConfirmarOpMañana(string? Documento)
        {
            if (Documento == null)
            {
                return BadRequest();
            }

            DateTime utcStart = DateTime.UtcNow.Date.AddDays(1).ToUniversalTime();
            DateTime utcEnd = DateTime.UtcNow.Date.AddDays(2).AddTicks(-1).ToUniversalTime();

            //DateTime utcStart = DateTime.Now.Date.AddDays(1).ToUniversalTime();
            //DateTime utcEnd = DateTime.Now.Date.AddDays(250).AddTicks(-1).ToUniversalTime();

            var estadoServicioIds = new List<int> { 3, 4, 7, 8, 9, 21, 22, 23 };

            var services = await _eurekaContext.ServiciosServicios
            .Include(c => c.EstadoServicio)
            .Include(c => c.Origen)
            .Include(c => c.Conductor)
                .ThenInclude(s => s.Usuario)
            .Include(c => c.TipoProcedimiento)
            .Include(s => s.Pasajero)
                .ThenInclude(p => p.Cliente)
            .Include(s => s.Pasajero)
                .ThenInclude(p => p.CategoriaPasajero)
            .Include(s => s.Pasajero)
                .ThenInclude(p => p.TipoDocumento)
            .Include(d => d.Destino)
                .ThenInclude(d => d.Barrio)
                    .ThenInclude(d => d.Upz)
                        .ThenInclude(d => d.Localidad)
                            .ThenInclude(d => d.Ciudad)
                                .ThenInclude(d => d.Departamento)
                                    .ThenInclude(d => d.Pais)
            .Where(x => x.Pasajero.NumeroDocumento == Documento &&
                       (x.FechaServicio > utcStart && x.FechaServicio < utcEnd) &&
                        estadoServicioIds.Contains(x.EstadoServicioId))
            .OrderBy(x => x.HoraRecogida) // Ordenar por HoraRecogida en orden descendente
            .Select(x => new
            {
                x,
                id_servicio = x.Id,
                fecha_recogida = x.HoraRecogida.ToString("yyyy-MM-dd"),
                hora_recogida = x.HoraRecogida.ToString("HH:mm"),
                hora_recogida_20 = x.HoraRecogida.AddMinutes(20).ToString("HH:mm"),
                fecha_servicio = x.FechaServicio.ToString("yyyy-MM-dd"),
                hora_servicio = x.FechaServicio.ToString("HH:mm"),
                origen_ciud = x.Origen.Barrio.Upz.Localidad.Ciudad.Nombre,
                origen_dir = x.Origen.Direccion,
                origen = x.Origen.Nombre,
                destino_ciud = x.Destino.Barrio.Upz.Localidad.Ciudad.Nombre,
                destino_dir = x.Destino.Direccion,
                destino = x.Destino.Nombre,
                operador_nombre = x.Conductor.Usuario.FirstName + " " + x.Conductor.Usuario.LastName,
                operador_placa = x.Conductor.Vehiculo.Placa,
                operador_telefono = x.Conductor.Telefono,
                estado = x.EstadoServicio.Nombre,
                estado_id = x.EstadoServicioId,
                hora_dateTime = x.HoraRecogida
            })
            .ToListAsync();

            if (!services.Any())
            {
                return NotFound();
            }

            bool isDelegate = false;

            var MensajeFinal = $"";
            foreach (var serviceDB in services)
            {
                switch (serviceDB.estado_id)
                {
                    case 23:
                        MensajeFinal += "ID: " + serviceDB.id_servicio +
                                " Recogida el día " + serviceDB.fecha_recogida +
                                " entre las " + serviceDB.hora_recogida + " y las " + serviceDB.hora_recogida_20 +
                                ", Origen: " + serviceDB.origen_ciud + " - " + serviceDB.origen + " - " + serviceDB.origen_dir +
                                ", llegada a su destino el " + serviceDB.fecha_servicio + " a las " + serviceDB.hora_servicio +
                                " en " + serviceDB.destino_ciud + " - " + serviceDB.destino + " - " + serviceDB.destino_dir +
                                ". El operador asignado es " + serviceDB.operador_nombre +
                                ", vehículo de Placa " + serviceDB.operador_placa +
                                $", número de contacto " + serviceDB.operador_telefono + "." + $" \n\n"; // Agrega un salto de línea después de cada registro

                        break;


                    default:

                        MensajeFinal += "ID: " + serviceDB.id_servicio +
                                    " Recogida el día " + serviceDB.fecha_recogida +
                                    " entre las " + serviceDB.hora_recogida + " y las " + serviceDB.hora_recogida_20 +
                                    ", Origen: " + serviceDB.origen_ciud + " - " + serviceDB.origen + " - " + serviceDB.origen_dir +
                                    ", llegada a su destino el " + serviceDB.fecha_servicio + " a las " + serviceDB.hora_servicio +
                                    " en " + serviceDB.destino_ciud + " - " + serviceDB.destino + " - " + serviceDB.destino_dir +
                                    ". El operador asignado se le estará informando a más tardar 2 horas antes de la prestación" +
                                    " del servicio, en caso de presentarse alguna novedad con la información sobre su servicio" +
                                    " indíquela por este medio para su respectiva gestión, en caso de no tener ninguna novedad" +
                                    $" por favor no responda este mensaje" + $" \n\n";


                        break;

                }
            }

            Mensaje MsgToReturn = new Mensaje()
            {
                Detalle = MensajeFinal
            };

            if (isDelegate)
            {
                MsgToReturn.Accion = "DELEGAR";
            }
            else
            {
                MsgToReturn.Accion = "INFORMAR";

            }

            return Ok(MsgToReturn);
        }







        






        [HttpGet("DatosUsuario/{Documento}")]
        public async Task<IActionResult> DatosUsuario(string? Documento)
        {
            if (string.IsNullOrEmpty(Documento))
            {
                return BadRequest("El documento no puede estar vacío.");
            }

            DateTime utcStart = DateTime.UtcNow.AddHours(-5).Date;
            DateTime utcEnd = utcStart.AddDays(1).AddTicks(-1);

            var services = await _eurekaContext.PasajerosPasajeros
                .Where(x => x.NumeroDocumento == Documento)
                .Select(x => new
                {
                    pasajero_id = x.Id,
                    pasajero_nombre = x.PrimerNombre + " " + x.PrimerApellido
                })
                .ToListAsync();

            if (!services.Any())
            {
                return NotFound("No se encontraron datos para el documento proporcionado.");
            }

            var respuestaDatosUser = services.Select(serviceDB => new Datos_usuario
            {
                Id = serviceDB.pasajero_id,
                Nombre = serviceDB.pasajero_nombre
            }).ToList();

            return Ok(respuestaDatosUser);
        }


        [HttpGet("GetStatus")]
        public async Task<IActionResult> GetStatus()
        {
            var status = await _eurekaContext.ServiciosEstadoservicios.ToListAsync();
            List<object> result = new List<object>();
            foreach (var obj in status)
            {
                result.Add(new
                {
                    id = obj.Id,
                    name = obj.Nombre
                });
            }

            return Ok(result);
        }

    }

    public class Mensaje
    {
        public string Detalle { get; set; }
        public string Accion { get; set; }
    }

    public class Datos_usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
