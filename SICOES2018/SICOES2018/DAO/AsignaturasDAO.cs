﻿using System.Data;
using System.Data.SqlClient;
using SICOES2018.BO;

namespace SICOES2018.DAO
{
    public class AsignaturasDAO : ConexionSQL
    {
        SqlCommand cmd;

        //Para agregar una nueva asignatura al sistema
        public int agregarAsignatura(AsignaturasBO datosAsig)
        {
            cmd = new SqlCommand("INSERT INTO Asignaturas (NomAsig, IDSemestreAsig, IDTipoAsig, IDModalidadAsig, IDPlanEstudios, CreditosAsig, Status, RequisitosAsig, HorasPre, HorasNoPre, Duracion) VALUES (@NomAsig, @IDSemestreAsig, @IDTipoAsig, @IDModalidadAsig, @IDPlanEstudios, @CreditosAsig, @Status, @RequisitosAsig, @HorasPre, @HorasNoPre, @Duracion)");

            cmd.Parameters.Add("@NomAsig", SqlDbType.VarChar).Value = datosAsig.NomAsig;
            cmd.Parameters.Add("@IDSemestreAsig", SqlDbType.Int).Value = datosAsig.IDSemestreAsig;
            cmd.Parameters.Add("@IDTipoAsig", SqlDbType.Int).Value = datosAsig.IDTipoAsig;
            cmd.Parameters.Add("@IDModalidadAsig", SqlDbType.Int).Value = datosAsig.IDModalidadAsig;
            cmd.Parameters.Add("@IDPlanEstudios", SqlDbType.Int).Value = datosAsig.IDPlanEstudios;
            cmd.Parameters.Add("@CreditosAsig", SqlDbType.Int).Value = datosAsig.CreditosAsig;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = datosAsig.Status;
            cmd.Parameters.Add("@RequisitosAsig", SqlDbType.VarChar).Value = datosAsig.RequisitosAsig;
            cmd.Parameters.Add("@HorasPre", SqlDbType.Int).Value = datosAsig.HorasPre;
            cmd.Parameters.Add("@HorasNoPre", SqlDbType.Int).Value = datosAsig.HorasNoPre;
            cmd.Parameters.Add("@Duracion", SqlDbType.Int).Value = datosAsig.Duracion;

            cmd.CommandType = CommandType.Text;
            return ejecutarComando(cmd);
        }

        //Para modificar el estado de vizualización de la asignatura [0 = NO, 1 = SI]
        public int modificarEstadoAsig(AsignaturasBO datosAsig)
        {
            cmd = new SqlCommand("UPDATE Asignaturas SET Status = @Status WHERE IDAsignatura = @IDAsignatura");

            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = datosAsig.Status;
            cmd.Parameters.Add("@IDAsignatura", SqlDbType.Int).Value = datosAsig.IDAsignatura;

            cmd.CommandType = CommandType.Text;
            return ejecutarComando(cmd);
        }

        //Para modificar la informacion de la asignatura dentro del sistema
        public int modificarInfoAsig(AsignaturasBO datosAsig)
        {
            cmd = new SqlCommand("UPDATE Asignaturas SET NomAsig = @NomAsig, IDSemestreAsig = @IDSemestreAsig , IDTipoAsig = @IDTipoAsig, IDModalidadAsig = @IDModalidadAsig, IDPlanEstudios = @IDPlanEstudios, CreditosAsig = @CreditosAsig, RequisitosAsig = @RequisitosAsig, HorasPre = @HorasPre, HorasNoPre = @HorasNoPre, Duracion = @Duracion WHERE IDAsignatura = @IDAsignatura");

            cmd.Parameters.Add("@NomAsig", SqlDbType.VarChar).Value = datosAsig.NomAsig;
            cmd.Parameters.Add("@IDSemestreAsig", SqlDbType.Int).Value = datosAsig.IDSemestreAsig;
            cmd.Parameters.Add("@IDTipoAsig", SqlDbType.Int).Value = datosAsig.IDTipoAsig;
            cmd.Parameters.Add("@IDModalidadAsig", SqlDbType.Int).Value = datosAsig.IDModalidadAsig;
            cmd.Parameters.Add("@IDPlanEstudios", SqlDbType.Int).Value = datosAsig.IDPlanEstudios;
            cmd.Parameters.Add("@CreditosAsig", SqlDbType.Int).Value = datosAsig.CreditosAsig;
            cmd.Parameters.Add("@RequisitosAsig", SqlDbType.VarChar).Value = datosAsig.RequisitosAsig;
            cmd.Parameters.Add("@HorasPre", SqlDbType.Int).Value = datosAsig.HorasPre;
            cmd.Parameters.Add("@HorasNoPre", SqlDbType.Int).Value = datosAsig.HorasNoPre;
            cmd.Parameters.Add("@Duracion", SqlDbType.Int).Value = datosAsig.Duracion;
            cmd.Parameters.Add("@IDAsignatura", SqlDbType.Int).Value = datosAsig.IDAsignatura;

            cmd.CommandType = CommandType.Text;
            return ejecutarComando(cmd);
        }
    }
}