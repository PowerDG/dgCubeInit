﻿using Abp.Application.Services.Dto;

namespace dgCube.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

