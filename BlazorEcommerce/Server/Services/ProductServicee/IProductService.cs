﻿namespace BlazorEcommerce.Server.Services.ProductServicee
{
	public interface IProductService
	{
		Task<ServiceResponse<List<Product>>> GetProductsAsync();
		Task<ServiceResponse<Product>> GetProductAsync(int productId);

	}
}
