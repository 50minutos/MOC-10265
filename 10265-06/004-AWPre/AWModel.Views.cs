//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Mapping.EntityViewGenerationAttribute(typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets3854678A075EA78BB8A0173A9069149D9F4FDAF0CB0519B36BDB03BB12A4FD46))]

namespace Edm_EntityMappingGeneratedViews
{
    
    
    /// <Summary>
    /// The type contains views for EntitySets and AssociationSets that were generated at design time.
    /// </Summary>
    public sealed class ViewsForBaseEntitySets3854678A075EA78BB8A0173A9069149D9F4FDAF0CB0519B36BDB03BB12A4FD46 : System.Data.Mapping.EntityViewContainer
    {
        
        /// <Summary>
        /// The constructor stores the views for the extents and also the hash values generated based on the metadata and mapping closure and views.
        /// </Summary>
        public ViewsForBaseEntitySets3854678A075EA78BB8A0173A9069149D9F4FDAF0CB0519B36BDB03BB12A4FD46()
        {
            this.EdmEntityContainerName = "AdventureWorksEntities";
            this.StoreEntityContainerName = "AdventureWorksModelStoreContainer";
            this.HashOverMappingClosure = "395a219e64e562ab86c877d1350f404b4236951490055a0bc530de3acc486f6a";
            this.HashOverAllExtentViews = "f910c8867e81778dae6b6c569a0c16181cf0f5121e88d3f10e432e5111928c98";
            this.ViewCount = 2;
        }
        
        /// <Summary>
        /// The method returns the view for the index given.
        /// </Summary>
        protected override System.Collections.Generic.KeyValuePair<string, string> GetViewAt(int index)
        {
            if ((index == 0))
            {
                return GetView0();
            }
            if ((index == 1))
            {
                return GetView1();
            }
            throw new System.IndexOutOfRangeException();
        }
        
        /// <Summary>
        /// return view for AdventureWorksModelStoreContainer.Contact
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView0()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AdventureWorksModelStoreContainer.Contact", @"
    SELECT VALUE -- Constructing Contact
        [AdventureWorksModel.Store.Contact](T1.Contact_ContactID, T1.Contact_NameStyle, T1.Contact_Title, T1.Contact_FirstName, T1.Contact_MiddleName, T1.Contact_LastName, T1.Contact_Suffix, T1.Contact_EmailAddress, T1.Contact_EmailPromotion, T1.Contact_Phone, T1.Contact_PasswordHash, T1.Contact_PasswordSalt, T1.Contact_AdditionalContactInfo, T1.Contact_rowguid, T1.Contact_ModifiedDate)
    FROM (
        SELECT 
            T.ContactID AS Contact_ContactID, 
            T.NameStyle AS Contact_NameStyle, 
            T.Title AS Contact_Title, 
            T.Nome AS Contact_FirstName, 
            T.MiddleName AS Contact_MiddleName, 
            T.Sobrenome AS Contact_LastName, 
            T.Suffix AS Contact_Suffix, 
            T.EmailAddress AS Contact_EmailAddress, 
            T.EmailPromotion AS Contact_EmailPromotion, 
            T.Phone AS Contact_Phone, 
            T.PasswordHash AS Contact_PasswordHash, 
            T.PasswordSalt AS Contact_PasswordSalt, 
            T.AdditionalContactInfo AS Contact_AdditionalContactInfo, 
            T.rowguid AS Contact_rowguid, 
            T.DataDeAlteracao AS Contact_ModifiedDate, 
            True AS _from0
        FROM AdventureWorksEntities.Contatos AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AdventureWorksEntities.Contatos
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView1()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AdventureWorksEntities.Contatos", @"
    SELECT VALUE -- Constructing Contatos
        [AdventureWorksModel.Contato](T1.Contato_ContactID, T1.Contato_NameStyle, T1.Contato_Title, T1.Contato_Nome, T1.Contato_MiddleName, T1.Contato_Sobrenome, T1.Contato_Suffix, T1.Contato_EmailAddress, T1.Contato_EmailPromotion, T1.Contato_Phone, T1.Contato_PasswordHash, T1.Contato_PasswordSalt, T1.Contato_AdditionalContactInfo, T1.Contato_rowguid, T1.Contato_DataDeAlteracao)
    FROM (
        SELECT 
            T.ContactID AS Contato_ContactID, 
            T.NameStyle AS Contato_NameStyle, 
            T.Title AS Contato_Title, 
            T.FirstName AS Contato_Nome, 
            T.MiddleName AS Contato_MiddleName, 
            T.LastName AS Contato_Sobrenome, 
            T.Suffix AS Contato_Suffix, 
            T.EmailAddress AS Contato_EmailAddress, 
            T.EmailPromotion AS Contato_EmailPromotion, 
            T.Phone AS Contato_Phone, 
            T.PasswordHash AS Contato_PasswordHash, 
            T.PasswordSalt AS Contato_PasswordSalt, 
            T.AdditionalContactInfo AS Contato_AdditionalContactInfo, 
            T.rowguid AS Contato_rowguid, 
            T.ModifiedDate AS Contato_DataDeAlteracao, 
            True AS _from0
        FROM AdventureWorksModelStoreContainer.Contact AS T
    ) AS T1");
        }
    }
}