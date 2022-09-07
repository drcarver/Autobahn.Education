//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IIeppresentLevel.g.cs
//***************************************************************************

/// <summary>
/// The IIeppresentLevel file
/// </summary>
public partial interface IIeppresentLevel
{
    #region "IIeppresentLevel Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String AcademicDescription { get; set; }

    System.String FunctionalDescription { get; set; }

    System.String GeneralEducationDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    System.String ParentConcernDescription { get; set; }

    System.String PreschoolDescription { get; set; }

    System.String StudentConcernDescription { get; set; }

    System.String StudentStrengthsDescription { get; set; }

    #endregion
}
