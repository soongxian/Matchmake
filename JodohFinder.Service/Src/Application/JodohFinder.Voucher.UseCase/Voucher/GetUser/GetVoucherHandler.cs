using JodohFinder.Guard;
using MediatR;

namespace JodohFinder.Voucher.UseCase
{
    public class GetVoucherHandler : IRequestHandler<GetVoucherQuery, List<VoucherDTO>>
    {
        private readonly IVoucherBS _voucherBS;

        public GetVoucherHandler(IVoucherBS voucherBS)
        {
            _voucherBS = voucherBS;
        }

        public async Task<List<VoucherDTO>> Handle(GetVoucherQuery request, CancellationToken cancellationToken)
        {
            Guid? voucherId = request.VoucherId ?? null;
            int? isUsed = request.VoucherIsUsed ?? null;

            var voucher = await _voucherBS.GetAsync(voucherId, isUsed, cancellationToken);
            if (voucher is null)
            {
                throw new GuardNotFoundException("Voucher");
            }

            return voucher.Select(r => r.JF_VoucherToDto()).ToList();
        }
    }
}
