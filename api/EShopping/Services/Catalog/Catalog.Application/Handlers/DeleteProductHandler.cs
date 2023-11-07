using Catalog.Application.Queries;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductByIdQuery, bool>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(DeleteProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.DeleteProduct(request.Id);
        }
    }
}
