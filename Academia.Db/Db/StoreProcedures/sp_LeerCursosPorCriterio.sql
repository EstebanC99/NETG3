CREATE PROCEDURE [dbo].[sp_LeerCursosPorCriterio]
    @pAnioCalendario INT NULL,
    @pMateriaID INT NULL,
    @pComisionID INT NULL,
    @pAlumnoID INT NULL
AS

BEGIN

    SELECT 
            c.ID_Curso                                  AS ID,
            c.AnioCalendario                            AS AnioCalendario,
            c.Cupo                                      AS Cupo,
            comi.ID_Comision                            AS ComisionID,
            comi.Descripcion                            AS ComisionDescripcion,
            m.ID_Materia                                AS MateriaID,
            m.Descripcion                               AS MateriaDescripcion,
            p.ID_Plan                                   AS PlanID,
            p.Descripcion                               AS PlanDescripcion,
            e.ID_Especialidad                           AS EspecialidadID,
            e.Descripcion                               AS EspecialidadDescripcion,
            CASE WHEN d.ID_Persona_Profesor IS NOT NULL
                THEN CONCAT(per.Nombre, ', ', per.Apellido) 
                ELSE 'Sin Asignar'
            END                                         AS ProfesorNombreApellido,
            m.HsSemanales                               AS HsSemanales,
            m.HsTotales                                 AS HsTotales,
            CASE WHEN ai.ID_Persona_Alumno IS NOT NULL
                THEN CAST(1 AS BIT)
                ELSE CAST(0 AS BIT)                  
            END                                         AS EstaInscripto
    FROM t_Curso c 
    INNER JOIN t_Comision comi ON comi.ID_Comision = c.ID_Comision
    INNER JOIN t_Materia m ON m.ID_Materia = c.ID_Materia
    INNER JOIN t_Plan p ON p.ID_Plan = m.ID_Plan
    INNER JOIN t_Especialidad e ON e.ID_Especialidad = p.ID_Especialidad
    LEFT JOIN t_DocenteCurso d ON c.ID_Curso = d.ID_Curso
    LEFT JOIN t_Persona per ON per.ID_Persona = d.ID_Persona_Profesor
    LEFT JOIN t_AlumnoInscripcion ai ON ai.ID_Curso = c.ID_Curso 
        AND ai.ID_Persona_Alumno = @pAlumnoID
    WHERE   (@pAnioCalendario IS NULL OR @pAnioCalendario = c.AnioCalendario)
    AND     (@pMateriaID IS NULL OR @pMateriaID = c.ID_Materia)
    AND     (@pComisionID IS NULL OR @pComisionID = c.ID_Comision)

END