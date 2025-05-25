﻿using FluentValidation;
using SmartCharging.Api.Dtos.Connector;

namespace SmartCharging.Api.Validators
{
    public class CreateConnectorValidator : AbstractValidator<CreateConnector>
    {
        public CreateConnectorValidator()
        {
            RuleFor(c => c.ChargeStationContextId)
            .InclusiveBetween(1, 5)
            .WithMessage("chargeStationIdentifier must be between 1 and 5.");

            RuleFor(c => c.MaxCurrent)
                .GreaterThan(0);
        }
    }
}