namespace ProyectoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Socios",
                c => new
                    {
                        SocioID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Cedula = c.String(),
                        Foto = c.String(maxLength: 200),
                        Direccion = c.String(),
                        Telefono = c.String(nullable: false),
                        Sexo = c.String(),
                        Edad = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Afiliados = c.String(),
                        Membresia = c.String(),
                        LugarTrabajo = c.String(),
                        DireccionOficina = c.String(),
                        TelefonoOficina = c.String(),
                        EstadoMembresia = c.String(),
                        FechaIngreso = c.DateTime(nullable: false),
                        FechaSalida = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SocioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Socios");
        }
    }
}
