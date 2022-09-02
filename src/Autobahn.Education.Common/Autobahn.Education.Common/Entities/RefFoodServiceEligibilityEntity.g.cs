//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFoodServiceEligibilityEntity.g.cs
//* Name:       Eligibility Status for School Food Service Programs
//* Definition: An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
//***************************************************************************

/// <summary>
/// Eligibility Status for School Food Service Programs <see cref="RefFoodServiceEligibility"/>
/// <para>
/// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19092">Eligibility Status for School Food Service Programs</a>
/// </para>
/// </summary>
[Table("RefFoodServiceEligibility", Schema = "Common")]
[Comment("An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.")]
public partial class RefFoodServiceEligibilityEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefFoodServiceEligibility Properties"
    public Int32? RefJurisdiction { get; set; }

    #endregion
}
