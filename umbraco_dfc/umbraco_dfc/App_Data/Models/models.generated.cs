//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "c8e74385dbb8db8c")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.5")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Forside</summary>
	[PublishedContentModel("forside")]
	public partial class Forside : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "forside";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Forside(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Forside, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Facebook: Facebook ikon
		///</summary>
		[ImplementPropertyType("facebook")]
		public IPublishedContent Facebook
		{
			get { return this.GetPropertyValue<IPublishedContent>("facebook"); }
		}

		///<summary>
		/// Forside overskrift: Overskrift på forside
		///</summary>
		[ImplementPropertyType("forsideOverskrift")]
		public string ForsideOverskrift
		{
			get { return this.GetPropertyValue<string>("forsideOverskrift"); }
		}

		///<summary>
		/// Forside tekst: Tekst til forsiden
		///</summary>
		[ImplementPropertyType("forsideTekst")]
		public string ForsideTekst
		{
			get { return this.GetPropertyValue<string>("forsideTekst"); }
		}

		///<summary>
		/// Header logo: Logo
		///</summary>
		[ImplementPropertyType("headerLogo")]
		public IPublishedContent HeaderLogo
		{
			get { return this.GetPropertyValue<IPublishedContent>("headerLogo"); }
		}

		///<summary>
		/// Hero 1024px: Hero billede 1024px
		///</summary>
		[ImplementPropertyType("hero1024px")]
		public IPublishedContent Hero1024px
		{
			get { return this.GetPropertyValue<IPublishedContent>("hero1024px"); }
		}

		///<summary>
		/// Hero 1280px: Hero billede 1280px
		///</summary>
		[ImplementPropertyType("hero1280px")]
		public IPublishedContent Hero1280px
		{
			get { return this.GetPropertyValue<IPublishedContent>("hero1280px"); }
		}

		///<summary>
		/// Hero 1440px: Hero billede 1440px
		///</summary>
		[ImplementPropertyType("hero1440px")]
		public IPublishedContent Hero1440px
		{
			get { return this.GetPropertyValue<IPublishedContent>("hero1440px"); }
		}

		///<summary>
		/// Hero 1536px: Hero billede 1536px
		///</summary>
		[ImplementPropertyType("hero1536px")]
		public IPublishedContent Hero1536px
		{
			get { return this.GetPropertyValue<IPublishedContent>("hero1536px"); }
		}

		///<summary>
		/// Hero  1920px: Hero billede 1920px
		///</summary>
		[ImplementPropertyType("hero1920px")]
		public IPublishedContent Hero1920px
		{
			get { return this.GetPropertyValue<IPublishedContent>("hero1920px"); }
		}

		///<summary>
		/// Hero 375px: Hero billede i 375px
		///</summary>
		[ImplementPropertyType("hero375px")]
		public IPublishedContent Hero375px
		{
			get { return this.GetPropertyValue<IPublishedContent>("hero375px"); }
		}

		///<summary>
		/// Hero 627px: Hero billede 627px
		///</summary>
		[ImplementPropertyType("hero627px")]
		public IPublishedContent Hero627px
		{
			get { return this.GetPropertyValue<IPublishedContent>("hero627px"); }
		}

		///<summary>
		/// Hero 768px: Hero billede 768px
		///</summary>
		[ImplementPropertyType("hero768px")]
		public IPublishedContent Hero768px
		{
			get { return this.GetPropertyValue<IPublishedContent>("hero768px"); }
		}

		///<summary>
		/// Instagram: Instagram ikon
		///</summary>
		[ImplementPropertyType("instagram")]
		public IPublishedContent Instagram
		{
			get { return this.GetPropertyValue<IPublishedContent>("instagram"); }
		}

		///<summary>
		/// Kagens dag billede: Billede til kagens dag
		///</summary>
		[ImplementPropertyType("kagensDagBillede")]
		public IPublishedContent KagensDagBillede
		{
			get { return this.GetPropertyValue<IPublishedContent>("kagensDagBillede"); }
		}

		///<summary>
		/// Kagens dag overskrift: Overskrift til kagens dag
		///</summary>
		[ImplementPropertyType("kagensDagOverskrift")]
		public string KagensDagOverskrift
		{
			get { return this.GetPropertyValue<string>("kagensDagOverskrift"); }
		}

		///<summary>
		/// Kagens dag tekst: Tekst til kagens dag
		///</summary>
		[ImplementPropertyType("kagensDagTekst")]
		public string KagensDagTekst
		{
			get { return this.GetPropertyValue<string>("kagensDagTekst"); }
		}

		///<summary>
		/// Smiley: Smiley rapport
		///</summary>
		[ImplementPropertyType("smiley")]
		public IPublishedContent Smiley
		{
			get { return this.GetPropertyValue<IPublishedContent>("smiley"); }
		}

		///<summary>
		/// tids billede: Billedet til højtid/årstid
		///</summary>
		[ImplementPropertyType("tidsBillede")]
		public IPublishedContent TidsBillede
		{
			get { return this.GetPropertyValue<IPublishedContent>("tidsBillede"); }
		}

		///<summary>
		/// Tids overskrift: Overskrif til højtid/årstid
		///</summary>
		[ImplementPropertyType("tidsOverskrift")]
		public string TidsOverskrift
		{
			get { return this.GetPropertyValue<string>("tidsOverskrift"); }
		}

		///<summary>
		/// Tids tekst: Tekst til højtid/årstid
		///</summary>
		[ImplementPropertyType("tidsTekst")]
		public string TidsTekst
		{
			get { return this.GetPropertyValue<string>("tidsTekst"); }
		}
	}

	/// <summary>Brød</summary>
	[PublishedContentModel("broed")]
	public partial class Broed : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "broed";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Broed(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Broed, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Kager</summary>
	[PublishedContentModel("kager")]
	public partial class Kager : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "kager";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Kager(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Kager, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Fristelser</summary>
	[PublishedContentModel("fristelser")]
	public partial class Fristelser : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "fristelser";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Fristelser(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Fristelser, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Bestillingskager</summary>
	[PublishedContentModel("bestillingskager")]
	public partial class Bestillingskager : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "bestillingskager";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Bestillingskager(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Bestillingskager, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Vores historie</summary>
	[PublishedContentModel("voresHistorie")]
	public partial class VoresHistorie : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "voresHistorie";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public VoresHistorie(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<VoresHistorie, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Kontakt os</summary>
	[PublishedContentModel("kontaktOs")]
	public partial class KontaktOs : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "kontaktOs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public KontaktOs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<KontaktOs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
