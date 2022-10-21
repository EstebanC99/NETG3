CREATE PROCEDURE [dbo].[sp_LeerAlumnosInscriptosPorCurso]
	@pCursoID INT = NULL
AS
BEGIN
	
	SELECT	
			p.ID_Persona		AS ID,
			p.Nombre			AS Nombre,
			p.Apellido			AS Apellido,
			p.Legajo			AS Legajo,
			pl.ID_Plan			AS PlanID,
			pl.Descripcion		AS PlanDescripcion,
			ai.Nota				AS Nota,
			ai.ID_Inscripcion	AS InscripcionID,
			ai.Condicion		AS Condicion
	FROM t_Curso c
	INNER JOIN t_AlumnoInscripcion ai ON ai.ID_Curso = c.ID_Curso
	INNER JOIN t_Persona p ON p.ID_Persona = ai.ID_Persona_Alumno
	INNER JOIN t_Plan pl ON pl.ID_Plan = p.ID_Plan
	WHERE (@pCursoID IS NULL OR c.ID_Curso = @pCursoID)

END
