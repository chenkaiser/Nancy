﻿namespace Nancy.Validation.Fluent
{
    using System.Collections.Generic;
    using FluentValidation.Validators;
    using Nancy.Validation.Rules;
    using FluentValidation.Internal;

    public class RegexAdapter : AdapterBase<RegularExpressionValidator>
    {
        public RegexAdapter(PropertyRule rule, RegularExpressionValidator validator)
            : base(rule, validator)
        {
        }

        public override IEnumerable<ValidationRule> GetRules()
        {
            yield return new RegexValidationRule(FormatMessage, GetMemberNames(), this.Validator.Expression);
        }
    }
}
