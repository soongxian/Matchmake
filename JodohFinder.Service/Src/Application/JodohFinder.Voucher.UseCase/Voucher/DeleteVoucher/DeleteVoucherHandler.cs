using JodohFinder.Voucher.UseCase;
using MediatR;

namespace JodohFinder.Voucher.Implementation.Command
{
    public class DeleteVoucherHandler : IRequestHandler<DeleteVoucherCommand, List<VoucherDTO>>
    {
        private readonly IVoucherBS _voucherBS;

        public DeleteVoucherHandler(IVoucherBS voucherBS)
        {
            _voucherBS = voucherBS;
        }

        public async Task<List<VoucherDTO>> Handle(DeleteVoucherCommand request, CancellationToken cancellationToken)
        {
            var deletedVouchers = await _voucherBS.DeleteAsync(request.VoucherId, cancellationToken);

            return deletedVouchers.JF_VoucherListToDto();
        }
    }
}