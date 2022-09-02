//***************************************************************************
//* DomainName: Common Models
//* FileName:   IProgramParticipationMigrant.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationMigrant file
/// </summary>
public partial interface IProgramParticipationMigrant
{
    #region "IProgramParticipationMigrant Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Birthdate Verification
    /// <para>
    /// The evidence by which a child's date of birth is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19418">Birthdate Verification</a>
    /// </para>
    /// </summary>
    System.String BirthdateVerification { get; set; }

    /// <summary>
    /// Migrant Education Program Continuation of Services Status
    /// <para>
    /// An indication that migrant children are receiving instructional or support services under the continuation of services authority ESEA Title III Section 1304(e)(2)-(3).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19555">Migrant Education Program Continuation of Services Status</a>
    /// </para>
    /// </summary>
    Boolean? ContinuationOfServicesStatus { get; set; }

    /// <summary>
    /// Designated Graduation School Identifier
    /// <para>
    /// The NCES school identification number that identifies the school or facility from which a student expects to graduate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19426">Designated Graduation School Identifier</a>
    /// </para>
    /// </summary>
    Guid? DesignatedGraduationSchoolId { get; set; }

    /// <summary>
    /// Immunization Record Flag
    /// <para>
    /// Indicates whether the school or MEP program has immunization records on file for the student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19428">Immunization Record Flag</a>
    /// </para>
    /// </summary>
    Boolean? ImmunizationRecordFlag { get; set; }

    /// <summary>
    /// Last Qualifying Move Date
    /// <para>
    /// The year, month and day of the last qualifying move of a migrant student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19171">Last Qualifying Move Date</a>
    /// </para>
    /// </summary>
    DateTime? LastQualifyingMoveDate { get; set; }

    /// <summary>
    /// Migrant Education Program Eligibility Expiration Date
    /// <para>
    /// The year, month, and day on which the child is no longer eligible for the Migrant Education Program. This date should initially be a date equal to 36 months from the Qualifying Arrival Date to indicate the end of MEP eligibility or the student reaches 22 years of age, whichever comes first.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19420">Migrant Education Program Eligibility Expiration Date</a>
    /// </para>
    /// </summary>
    DateTime? MepEligibilityExpirationDate { get; set; }

    /// <summary>
    /// Migrant Student Qualifying Arrival Date
    /// <para>
    /// The qualifying arrival date (QAD) is the month, date, and year that the child completed a move with his or her parent to enable the parent to find qualifying employment. In some cases, the child and worker may not always move together, in which case the QAD would be the date that the child joins the worker who has  already moved, or the date the worker joins the child who has already moved. The QAD is the date the child's eligibility for the Migrant Education Program begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19422">Migrant Student Qualifying Arrival Date</a>
    /// </para>
    /// </summary>
    DateTime? MigrantStudentQualifyingArrivalDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Migrant Prioritized for Services
    /// <para>
    /// An indication that a migratory child 1) is failing to meet, or most at risk of failing to meet, the state's challenging academic content standards and student academic achievement standards; and 2) has experienced interruptions in their education during the regular school year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19554">Migrant Prioritized for Services</a>
    /// </para>
    /// </summary>
    Boolean? PrioritizedForServices { get; set; }

    /// <summary>
    /// Qualifying Move From City
    /// <para>
    /// The name of the city in which the child resided prior to the qualifying move.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19423">Qualifying Move From City</a>
    /// </para>
    /// </summary>
    System.String QualifyingMoveFromCity { get; set; }

    /// <summary>
    /// Continuation of Services Reason
    /// <para>
    /// Reason why the student is being served under the continuation of services provision of the MEP.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19419">Continuation of Services Reason</a>
    /// </para>
    /// </summary>
    Guid? RefContinuationOfServicesReasonId { get; set; }

    /// <summary>
    /// Migrant Education Program Enrollment Type
    /// <para>
    /// The type of school/migrant education project in which instruction and/or support services are provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19427">Migrant Education Program Enrollment Type</a>
    /// </para>
    /// </summary>
    Guid? RefMepEnrollmentTypeId { get; set; }

    /// <summary>
    /// Migrant Education Program Project Based
    /// <para>
    /// Indicates the type of MEP project based on the location where the MEP services are held.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19430">Migrant Education Program Project Based</a>
    /// </para>
    /// </summary>
    Guid? RefMepProjectBasedId { get; set; }

    /// <summary>
    /// Migrant Education Program Services Type
    /// <para>
    /// The type of services received by participating migrant students in the migrant education program (MEP).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19186">Migrant Education Program Services Type</a>
    /// </para>
    /// </summary>
    Guid? RefMepServiceTypeId { get; set; }

    /// <summary>
    /// Qualifying Move From Country
    /// <para>
    /// The abbreviation code for a country (other than the US) area in which the child resided prior to the qualifying move.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19424">Qualifying Move From Country</a>
    /// </para>
    /// </summary>
    Guid? RefQualifyingMoveFromCountryId { get; set; }

    /// <summary>
    /// Qualifying Move From State
    /// <para>
    /// The postal abbreviation code for a state (within the United States) or outlying area in which the child resided prior to the qualifying move.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19425">Qualifying Move From State</a>
    /// </para>
    /// </summary>
    Guid? RefQualifyingMoveFromStateId { get; set; }

    #endregion
}
