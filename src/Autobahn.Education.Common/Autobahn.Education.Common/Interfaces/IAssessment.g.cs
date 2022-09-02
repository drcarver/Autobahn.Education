//***************************************************************************
//* DomainName: Common Models
//* FileName:   IAssessment.g.cs
//***************************************************************************

/// <summary>
/// The IAssessment file
/// </summary>
public partial interface IAssessment
{
    #region "IAssessment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Assessment Family Short Name
    /// <para>
    /// The abbreviated title of the Assessment Family. An Assessment Family is a set of assessments with a common name, jurisdiction, or focus.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19934">Assessment Family Short Name</a>
    /// </para>
    /// </summary>
    System.String AssessmentFamilyShortName { get; set; }

    /// <summary>
    /// Assessment Family Title
    /// <para>
    /// The full title of the Assessment Family. An Assessment Family is a set of assessments with a common name, jurisdiction, or focus, such as Graduate Record Exam or National Assessment of Educational Progress.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19933">Assessment Family Title</a>
    /// </para>
    /// </summary>
    System.String AssessmentFamilyTitle { get; set; }

    /// <summary>
    /// Assessment Revision Date
    /// <para>
    /// The month, day, and year that the conceptual design for the assessment was most recently revised substantially.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20519">Assessment Revision Date</a>
    /// </para>
    /// </summary>
    DateTime? AssessmentRevisionDate { get; set; }

    System.String Guid { get; set; }

    /// <summary>
    /// Assessment Identification System
    /// <para>
    /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19158">Assessment Identification System</a>
    /// </para>
    /// </summary>
    Int32? IdentificationSystem { get; set; }

    /// <summary>
    /// Assessment Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to an assessment by a school, school system, a state, or other agency or entity.  This may be the publisher identifier.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19152">Assessment Identifier</a>
    /// </para>
    /// </summary>
    System.String Identifier { get; set; }

    /// <summary>
    /// Assessment Objective
    /// <para>
    /// This is the objective that the assessment is measuring.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19373">Assessment Objective</a>
    /// </para>
    /// </summary>
    System.String Objective { get; set; }

    /// <summary>
    /// Assessment Provider
    /// <para>
    /// Identifies the provider or publisher of the assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20009">Assessment Provider</a>
    /// </para>
    /// </summary>
    System.String Provider { get; set; }

    /// <summary>
    /// Assessment Academic Subject
    /// <para>
    /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19021">Assessment Academic Subject</a>
    /// </para>
    /// </summary>
    Guid RefAcademicSubjectId { get; set; }

    /// <summary>
    /// Assessment Purpose
    /// <para>
    /// The reason for which an assessment is designed or delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19026">Assessment Purpose</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentPurposeId { get; set; }

    /// <summary>
    /// Assessment Type Administered to Children with Disabilities
    /// <para>
    /// The types of assessments administered to children with disabilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19405">Assessment Type Administered to Children with Disabilities</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

    /// <summary>
    /// Assessment Type
    /// <para>
    /// The category of an assessment based on format and content.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19029">Assessment Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentTypeId { get; set; }

    /// <summary>
    /// Assessment Short Name
    /// <para>
    /// An abbreviated title for an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19932">Assessment Short Name</a>
    /// </para>
    /// </summary>
    System.String ShortName { get; set; }

    /// <summary>
    /// Assessment Title
    /// <para>
    /// The title or name of the assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19028">Assessment Title</a>
    /// </para>
    /// </summary>
    System.String Title { get; set; }

    #endregion
}
