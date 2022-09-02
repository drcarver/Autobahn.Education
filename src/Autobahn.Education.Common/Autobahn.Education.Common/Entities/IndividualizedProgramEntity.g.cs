//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgram file
/// </summary>
[Table("IndividualizedProgram", Schema = "Common")]
public partial class IndividualizedProgramEntity : EntityBase, IIndividualizedProgram
{
    #region "IIndividualizedProgram Properties"
    /// <summary>
    /// Individualized Program Inclusion Minutes Per Week
    /// <para>
    /// The number of minutes per week that a student with disabilities is served in a special education setting separate from his or her non-disabled peers.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20199">Individualized Program Inclusion Minutes Per Week</a>
    /// </para>
    /// </summary>
    [Comment("The number of minutes per week that a student with disabilities is served in a special education setting separate from his or her non-disabled peers.")]
    public Int32? InclusionMinutesPerWeek { get; set; }

    /// <summary>
    /// Inclusive Setting Indicator
    /// <para>
    /// Indicates that services are provided to the child in a place where children of all abilities learn together.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates that services are provided to the child in a place where children of all abilities learn together.")]
    public Boolean? InclusiveSettingIndicator { get; set; }

    /// <summary>
    /// Individualized Program Date
    /// <para>
    /// The year, month and day on which the status of an individualized program for a student is significantly altered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20197">Individualized Program Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which the status of an individualized program for a student is significantly altered.")]
    public DateTime? IndividualizedProgramDate { get; set; }

    /// <summary>
    /// Individualized Program NonInclusion Minutes Per Week
    /// <para>
    /// The number of minutes per week that a student with disabilities is served in a regular classroom with his or her non-disabled peers.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20198">Individualized Program NonInclusion Minutes Per Week</a>
    /// </para>
    /// </summary>
    [Comment("The number of minutes per week that a student with disabilities is served in a regular classroom with his or her non-disabled peers.")]
    public Int32? NonInclusionMinutesPerWeek { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Date Type
    /// <para>
    /// An indication of the significance of a date to an individualized program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20196">Individualized Program Service Plan Date Type</a>
    /// </para>
    /// </summary>
    [Comment("An indication of the significance of a date to an individualized program.")]
    public Int32? RefIndividualizedProgramDateType { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Meeting Location
    /// <para>
    /// The place in which a child's service plan meeting is held.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20202">Individualized Program Service Plan Meeting Location</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefIndividualizedProgramLocation")]
    [Comment("The place in which a child's service plan meeting is held.")]
    public Guid? RefIndividualizedProgramLocationId { get; set; }

    /// <summary>
    /// Individualized Program Transition Plan Type
    /// <para>
    /// The post-school transition plan for the student recorded on their Individualized Education Program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20200">Individualized Program Transition Plan Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefIndividualizedProgramTransitionType")]
    [Comment("The post-school transition plan for the student recorded on their Individualized Education Program.")]
    public Guid? RefIndividualizedProgramTransitionTypeId { get; set; }

    /// <summary>
    /// Individualized Program Type
    /// <para>
    /// A designation of the type of program developed for a student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19320">Individualized Program Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefIndividualizedProgramType")]
    [Comment("A designation of the type of program developed for a student.")]
    public Guid? RefIndividualizedProgramTypeId { get; set; }

    /// <summary>
    /// Student Support Service Type
    /// <para>
    /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19273">Student Support Service Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefStudentSupportServiceType")]
    [Comment("Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.")]
    public Guid? RefStudentSupportServiceTypeId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Date
    /// <para>
    /// The year, month and day on which the status of the service plan for a child is established or significantly altered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20201">Individualized Program Service Plan Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which the status of the service plan for a child is established or significantly altered.")]
    public DateTime? ServicePlanDate { get; set; }

    /// <summary>
    /// Individualized Program Service Plan End Date
    /// <para>
    /// The year, month and day on which the status of the service plan for a child effectively ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20664">Individualized Program Service Plan End Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which the status of the service plan for a child effectively ends.")]
    public DateTime? ServicePlanEndDate { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Meeting Participants
    /// <para>
    /// The position titles of individuals who attend the service plan meeting.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20203">Individualized Program Service Plan Meeting Participants</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4000,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The position titles of individuals who attend the service plan meeting.")]
    public System.String ServicePlanMeetingParticipants { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Reevaluation Date
    /// <para>
    /// Date student will be reevaluated for continued placement in a support program(s).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20207">Individualized Program Service Plan Reevaluation Date</a>
    /// </para>
    /// </summary>
    [Comment("Date student will be reevaluated for continued placement in a support program(s).")]
    public DateTime? ServicePlanReevaluationDate { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Signature Date
    /// <para>
    /// The year, month and day on which the service plan document is signed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20205">Individualized Program Service Plan Signature Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which the service plan document is signed.")]
    public DateTime? ServicePlanSignatureDate { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Signed By
    /// <para>
    /// The position titles of individuals who sign a written service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20204">Individualized Program Service Plan Signed By</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4000,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The position titles of individuals who sign a written service plan.")]
    public System.String ServicePlanSignedBy { get; set; }

    /// <summary>
    /// IEP Transfer of Rights Statement
    /// <para>
    /// Beginning not later than one year before the child reaches the age of majority under State law, the IEP must include a statement that the child has been informed of the child's rights under Part B of the Individuals with Disabilities Education Act, if any, that will transfer to the child on reaching the age of majority under 300.520.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20663">IEP Transfer of Rights Statement</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Beginning not later than one year before the child reaches the age of majority under State law, the IEP must include a statement that the child has been informed of the child's rights under Part B of the Individuals with Disabilities Education Act, if any, that will transfer to the child on reaching the age of majority under 300.520.")]
    public System.String TransferOfRightsStatement { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The post-school transition plan for the student recorded on their Individualized Education Program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20200">Individualized Program Transition Plan Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIndividualizedProgramTransitionTypeEntity RefIndividualizedProgramTransitionTypeEntity { get; set; }

    /// <summary>
    /// A designation of the type of program developed for a student.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19320">Individualized Program Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIndividualizedProgramTypeEntity RefIndividualizedProgramTypeEntity { get; set; }

    /// <summary>
    /// The place in which a child's service plan meeting is held.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20202">Individualized Program Service Plan Meeting Location</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIndividualizedProgramLocationEntity RefIndividualizedProgramLocationEntity { get; set; }

    /// <summary>
    /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19273">Student Support Service Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefStudentSupportServiceTypeEntity RefStudentSupportServiceTypeEntity { get; set; }

    #endregion
}
