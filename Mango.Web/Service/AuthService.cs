using Mango.Web.Models;
using Mango.Web.Service.IService;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Service
{
	public class AuthService : IAuthService
	{
		private readonly IBaseService _baseService;

		public AuthService(IBaseService baseService)
		{
			_baseService = baseService;
		}

		public async Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registrationRequestDto)
		{
			return await _baseService.SeedAsync(new RequestDto()
			{
				ApiType = ApiType.POST,
				Data = registrationRequestDto,
				Url = AuthAPIBase + "/api/auth/AssignRole"
			});
		}

		public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
		{
			return await _baseService.SeedAsync(new RequestDto()
			{
				ApiType = ApiType.POST,
				Data = loginRequestDto,
				Url = AuthAPIBase + "/api/auth/login"
			}, withBearer: false);
		}

		public async Task<ResponseDto?> RegisterAsync(RegistrationRequestDto registrationRequestDto)
		{
			return await _baseService.SeedAsync(new RequestDto()
			{
				ApiType = ApiType.POST,
				Data = registrationRequestDto,
				Url = AuthAPIBase + "/api/auth/register"
			}, withBearer: false);
		}
	}
}
