using MediatR;

namespace JodohFinder.Voucher.UseCase
{
    public class AddVoucherHandler : IRequestHandler<AddVoucherCommand, List<VoucherDTO>>
    {
        private readonly IVoucherBS _voucherBS;

        public AddVoucherHandler(IVoucherBS voucherBS)
        {
            _voucherBS = voucherBS;
        }

        public async Task<List<VoucherDTO>> Handle(AddVoucherCommand request, CancellationToken cancellationToken)
        {
            var vouchers = await _voucherBS.UpsertAsync(request.Count, request.Voucher_CreBy, cancellationToken);
            return vouchers.JF_VoucherListToDto();
        }
    }
}
