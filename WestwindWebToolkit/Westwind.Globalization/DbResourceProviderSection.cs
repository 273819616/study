using System;
using System.Web;
using System.Web.UI.Design;
using System.Configuration;
using System.Web.Configuration;
using System.ComponentModel;
using System.Web.Compilation;
using System.Collections.Generic;

namespace Westwind.Globalization
{
    /// <summary>
    /// This is the resource provider section that mimics the settings stored in DbResourceConfiguration object.
    /// </summary>
    public class DbResourceProviderSection : ConfigurationSection
    {
        [ConfigurationProperty("connectionString", DefaultValue = ""),
        Description("The connection string used to connect to the db Resourcewl provider")]
        public string ConnectionString
        {
            get { return this["connectionString"] as string; }
            set { this["connectionString"] = value; }
        }


        [ConfigurationProperty("resourceTableName", DefaultValue = "Localizations"),
        Description("The name of the table used in the Connection String database for localizations.")]
        public string ResourceTableName
        {
            get { return this["resourceTableName"] as string; }
            set { this["resourceTableName"] = value; }
        }

        [Description("Determines whether WebForms (using App_Global/LocalResource) or any other .NET project type is used. Options are WebForms and Class."),
ConfigurationProperty("projectType", DefaultValue = GlobalizationProjectTypes.WebForms)]
        public GlobalizationProjectTypes ProjectType
        {
            get { return (GlobalizationProjectTypes)this["projectType"]; }
            set { this["projectType"] = value; }
        }        
 

        [ConfigurationProperty("designTimeVirtualPath", DefaultValue = ""),
        Description("The virtual path to the application. This value is used at design time and should be in the format of: /MyVirtual")]
        public string DesignTimeVirtualPath
        {
            get { return this["designTimeVirtualPath"] as string; }
            set { this["designTimeVirtualPath"] = value; }
        }



        [Description("Determines whether the DbResourceControl shows its localization options on the page."),
         ConfigurationProperty("showLocalizationControlOptions", DefaultValue = "false")]
        public bool ShowLocalizationControlOptions
        {
            get { return (bool)this["showLocalizationControlOptions"]; }
            set { this["showLocalizationControlOptions"] = value; }
        }

        [Description("Determines whether the DbResourceControl shows icons next to each control of a page to jump to the localization page."),
         ConfigurationProperty("showControlIcons", DefaultValue = "false")]
        public bool ShowControlIcons
        {
            get { return (bool)this["showControlIcons"]; }
            set { this["showControlIcons"] = value; }
        }


        [Description("The web path to the administration localization form used to display and edit resources."),
         ConfigurationProperty("localizationFormWebPath", DefaultValue = "~/admin/localizeform.aspx")]
        public string LocalizationFormWebPath
        {
            get { return this["localizationFormWebPath"] as string; }
            set { this["localizationFormWebPath"] = value; }
        }

        [Description("Determines whether any missing resources are automatically added to the Invariant culture. Defaults to true"),
         ConfigurationProperty("addMissingResources", DefaultValue = true)]
        public bool AddMissingResources
        {
            get { return (bool)this["addMissingResources"]; }
            set { this["addMissingResources"] = value; }
        }

        [Description("If set to true uses Visual Studio naming for generate resource names that have a ResourceX prefix. The default doesn't generate the Resource text and omits the number if possible"),
         ConfigurationProperty("useVsNetResourceNaming", DefaultValue = false)]
        public bool UseVsNetResourceNaming
        {
            get { return (bool)this["useVsNetResourceNaming"]; }
            set { this["useVsNetResourceNaming"] = value; }
        }

        [Description("Determines whether a strongly typed resource is created when database resources are exported to a ResX file"),
         ConfigurationProperty("stronglyTypedGlobalResource", DefaultValue = "~/App_Code/Resources.cs,AppResources")]
        public string StronglyTypedGlobalResource
        {
            get { return (string)this["stronglyTypedGlobalResource"]; }
            set { this["stronglyTypedGlobalResource"] = value; }
        }




        public DbResourceProviderSection(string ConnectionString, string ResourceTableName, string DesignTimeVirtualPath)
        {
            this.ConnectionString = ConnectionString;
            this.DesignTimeVirtualPath = DesignTimeVirtualPath;
            this.ResourceTableName = ResourceTableName;
        }

        public DbResourceProviderSection()
        {

        }

    }
}
