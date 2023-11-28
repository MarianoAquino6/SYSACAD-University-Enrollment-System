using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum
{
    public enum Carrera
    {
        TUP,
        TUSI
    }

    public enum Log 
    { 
        Admin, 
        Estudiante 
    }

    public enum ValidacionInscripcionResultado
    {
        SinSeleccion,
        Exitoso,
        NoCumpleAlgunosRequisitos,
        NoCumpleNingunRequisito,
        SinCupoAbsoluto,
        SinCupoParcial
    }

    public enum ModoValidacionInput
    {
        CursoAgregarOEditar,
        CursoRequisitos,
        Estudiantes,
        MediosPagoTarjeta,
        MediosPagoTransferencia,
        Profesores
    }

    public enum MensajeRespuestaValidacionCredencialesContraseña
    {
        OK,
        camposVacios,
        noEncontrado,
        ERROR
    }

    public enum RespuestaEvento
    {
        Ejecutar,
        NoEjecutar
    }

    public enum TipoEvento
    { 
        PagoCuota,
        InicioCuatri
    }

    public enum Reporte
    {
        InscripcionPorPeriodo,
        EstudiantesEnCursoEspecifico,
        IngresoPorConceptoDePago,
        InscripcionPorCarrera,
        ListaDeEsperaDeCursos
    }

 }
