﻿using BuyMe.Application.Common.Behaviour;
using BuyMe.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BuyMe.Application.Currency.Commonds.DeleteCurrency
{
    public class DeleteCurrencyCommond : IRequest<Unit>
    {
        public int CurrencyId { get; set; }

        public class DeleteEmployeeCommondHandler : IRequestHandler<DeleteCurrencyCommond, Unit>
        {
            private readonly IBuyMeDbContext context;

            public DeleteEmployeeCommondHandler(IBuyMeDbContext context)
            {
                this.context = context;
            }

            public async Task<Unit> Handle(DeleteCurrencyCommond request, CancellationToken cancellationToken)
            {
                var currency = await context.Currencies.FindAsync(request.CurrencyId);
                Guard.Against.Null(currency, request.CurrencyId);
                context.Currencies.Remove(currency);
                await context.SaveChangesAsync(cancellationToken);
                return Unit.Value;
            }
        }
    }
}