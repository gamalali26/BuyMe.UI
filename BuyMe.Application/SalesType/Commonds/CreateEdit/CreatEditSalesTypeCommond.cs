﻿using BuyMe.Application.Common.Behaviour;
using BuyMe.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BuyMe.Application.SalesType.Commonds.CreateEdit
{
    public class CreatEditSalesTypeCommond : IRequest<int>
    {
        public int? SalesTypeId { get; set; }
        public string SalesTypeName { get; set; }
        public string SalesTypeDescription { get; set; }
        public string CompanyId { get; set; }

        public class CreatEditSalesTypeCommondHandler : IRequestHandler<CreatEditSalesTypeCommond, int>
        {
            private readonly IBuyMeDbContext _context;
            private readonly ICurrentUserService _currentUserService;

            public CreatEditSalesTypeCommondHandler(IBuyMeDbContext context, ICurrentUserService currentUserService)
            {
                _context = context;
                _currentUserService = currentUserService;
            }

            public async Task<int> Handle(CreatEditSalesTypeCommond request, CancellationToken cancellationToken)
            {
                Domain.Entities.SalesType customerType;
                if (request.SalesTypeId.HasValue)
                {
                    var entity = await _context.SalesTypes.FindAsync(request.SalesTypeId);
                    Guard.Against.Null(entity, request.SalesTypeId);
                    customerType = entity;
                }
                else
                {
                    customerType = new Domain.Entities.SalesType();
                    await _context.SalesTypes.AddAsync(customerType);
                    customerType.CompanyId = _currentUserService.CompanyId;
                }
                customerType.SalesTypeDescription = request.SalesTypeDescription;
                customerType.SalesTypeName = request.SalesTypeName;

                await _context.SaveChangesAsync(cancellationToken);
                return customerType.Id;
            }
        }
    }
}