// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.ArrayOptions.CheckVolatileTableConsistency
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        public static IValidationResult InvalidVolatileTableUsage(IValidate test, IReadable referenceNode, IReadable positionNode, string tableId, string incompatibleFeature)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckVolatileTableConsistency,
                ErrorId = ErrorIds.InvalidVolatileTableUsage,
                FullId = "2.77.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Table '{0}' is marked as volatile, but it uses features incompatible with volatility: {1}.", tableId, incompatibleFeature),
                HowToFix = "Remove the 'volatile' option from the <ArrayOptions> tag (e.g. options=\";volatile;\"), or remove the incompatible features from the table (such as alarmed columns, foreign keys, or DVE usage)." + Environment.NewLine + "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint InvalidVolatileTableUsage = 1;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckVolatileTableConsistency = 77;
    }
}