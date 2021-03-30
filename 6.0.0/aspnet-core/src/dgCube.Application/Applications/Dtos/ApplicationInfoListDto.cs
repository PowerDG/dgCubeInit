

using System;
using Abp.Application.Services.Dto;
using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using dgCube;
using System.Collections.ObjectModel;


namespace dgCube.Dtos
{	
	/// <summary>
	/// 的列表DTO
	/// <see cref="ApplicationInfo"/>
	/// </summary>
    public class ApplicationInfoListDto  
    {

        
		/// <summary>
		/// Id
		/// </summary>
		public int? Id { get; set; }



		/// <summary>
		/// ApplicationName
		/// </summary>
		public string ApplicationName { get; set; }



		/// <summary>
		/// ApplicationTitle
		/// </summary>
		public string ApplicationTitle { get; set; }



		/// <summary>
		/// Introduction
		/// </summary>
		public string Introduction { get; set; }



		/// <summary>
		/// ServiceProvider
		/// </summary>
		public string ServiceProvider { get; set; }



		/// <summary>
		/// Version
		/// </summary>
		public string Version { get; set; }



		/// <summary>
		/// Url
		/// </summary>
		public string Url { get; set; }



		/// <summary>
		/// Status
		/// </summary>
		public DeploymentStatus Status { get; set; }



		/// <summary>
		/// IconUrl
		/// </summary>
		public string IconUrl { get; set; }



		/// <summary>
		/// Images
		/// </summary>
		public string Images { get; set; }



		/// <summary>
		/// Videos
		/// </summary>
		public string Videos { get; set; }



		/// <summary>
		/// Tags
		/// </summary>
		public string Tags { get; set; }



		/// <summary>
		/// ContentRef
		/// </summary>
		public string ContentRef { get; set; }



		/// <summary>
		/// ContentType
		/// </summary>
		public string ContentType { get; set; }



		/// <summary>
		/// EnterprisesCardJson
		/// </summary>
		public string EnterprisesCardJson { get; set; }



		/// <summary>
		/// CreatedTime
		/// </summary>
		public DateTime CreatedTime { get; set; }



		
							//// custom codes
									
							

							//// custom codes end
    }
}