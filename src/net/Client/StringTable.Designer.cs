﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.MediaServices.Client {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StringTable {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringTable() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WindowsAzure.MediaServices.Client.StringTable", typeof(StringTable).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Files array need to have at least one element..
        /// </summary>
        internal static string ArgumentExceptionForEmptyFileArray {
            get {
                return ResourceManager.GetString("ArgumentExceptionForEmptyFileArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AssetFile can&apos;t be created out of context of asset. Use IAsset.AssetFiles.Create  method instead. .
        /// </summary>
        internal static string AssetFileCreateParentAssetIsNull {
            get {
                return ResourceManager.GetString("AssetFileCreateParentAssetIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To encrypt assets on ingest the bulk ingest context must be created with an output folder specified..
        /// </summary>
        internal static string BulkIngestAssetEncryptionRequiresAnOutputFolderSpecified {
            get {
                return ResourceManager.GetString("BulkIngestAssetEncryptionRequiresAnOutputFolderSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output folder already contains file with name {0}. Please delete file or specify override option..
        /// </summary>
        internal static string BulkIngestFileExists {
            get {
                return ResourceManager.GetString("BulkIngestFileExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder specified does not exist..
        /// </summary>
        internal static string BulkIngestFolderDoesNotExist {
            get {
                return ResourceManager.GetString("BulkIngestFolderDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ingest manifest with id {0} not found in a system..
        /// </summary>
        internal static string BulkIngestManifest404 {
            get {
                return ResourceManager.GetString("BulkIngestManifest404", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task of type(IIngestManifestFile) has null in Result property..
        /// </summary>
        internal static string BulkIngestNREForFileTaskCreation {
            get {
                return ResourceManager.GetString("BulkIngestNREForFileTaskCreation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string BulkIngestProvidedFileDoesNotExist {
            get {
                return ResourceManager.GetString("BulkIngestProvidedFileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Asset creation options for asset indicates that common encryption is used for given asset with id {0}. Please verify that asset has corresponding content key..
        /// </summary>
        internal static string CommonEncryptionContentKeyIsMissing {
            get {
                return ResourceManager.GetString("CommonEncryptionContentKeyIsMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task must have at least one input asset..
        /// </summary>
        internal static string EmptyInputArray {
            get {
                return ResourceManager.GetString("EmptyInputArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task must have at least one output asset..
        /// </summary>
        internal static string EmptyOutputArray {
            get {
                return ResourceManager.GetString("EmptyOutputArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There must be at least one task..
        /// </summary>
        internal static string EmptyTaskArray {
            get {
                return ResourceManager.GetString("EmptyTaskArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New output can&apos;t be added to submitted job task..
        /// </summary>
        internal static string ErrorAddingNewTaskToSubmittedJob {
            get {
                return ResourceManager.GetString("ErrorAddingNewTaskToSubmittedJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} cannot be null..
        /// </summary>
        internal static string ErrorArgCannotBeNull {
            get {
                return ResourceManager.GetString("ErrorArgCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} cannot be null or empty..
        /// </summary>
        internal static string ErrorArgCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("ErrorArgCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Asset name is null or empty string..
        /// </summary>
        internal static string ErrorAssetNameNullorEmpty {
            get {
                return ResourceManager.GetString("ErrorAssetNameNullorEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not create Asset with zero files..
        /// </summary>
        internal static string ErrorAssetZeroFileCount {
            get {
                return ResourceManager.GetString("ErrorAssetZeroFileCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified blob is too big to be uploaded..
        /// </summary>
        internal static string ErrorBlobTooBigToUpload {
            get {
                return ResourceManager.GetString("ErrorBlobTooBigToUpload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input asset cannot be parsed..
        /// </summary>
        internal static string ErrorCannotParseInput {
            get {
                return ResourceManager.GetString("ErrorCannotParseInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output asset cannot be parsed..
        /// </summary>
        internal static string ErrorCannotParseOutout {
            get {
                return ResourceManager.GetString("ErrorCannotParseOutout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Content Keys for Common Encryption must be 128-bits (16 bytes) in length..
        /// </summary>
        internal static string ErrorCommonEncryptionKeySize {
            get {
                return ResourceManager.GetString("ErrorCommonEncryptionKeySize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Guid.Empty is not allowed as a key identifier..
        /// </summary>
        internal static string ErrorCreateKey_EmptyGuidNotAllowed {
            get {
                return ResourceManager.GetString("ErrorCreateKey_EmptyGuidNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Content Keys for common encryption must be 128-bits (16 bytes) in length..
        /// </summary>
        internal static string ErrorCreateKey_KeyMustBe128Bits {
            get {
                return ResourceManager.GetString("ErrorCreateKey_KeyMustBe128Bits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An asset file&apos;s name must not be null, empty or white space..
        /// </summary>
        internal static string ErrorCreatingAssetFileEmptyFileName {
            get {
                return ResourceManager.GetString("ErrorCreatingAssetFileEmptyFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An asset cannot contain files with the same name..
        /// </summary>
        internal static string ErrorCreatingAssetWithDuplicateFileNames {
            get {
                return ResourceManager.GetString("ErrorCreatingAssetWithDuplicateFileNames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An asset file must not be null or empty..
        /// </summary>
        internal static string ErrorCreatingAssetWithEmptyFileName {
            get {
                return ResourceManager.GetString("ErrorCreatingAssetWithEmptyFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An ingest manifest file&apos;s path must not be null, empty or white space..
        /// </summary>
        internal static string ErrorCreatingIngestManifestFileEmptyFilePath {
            get {
                return ResourceManager.GetString("ErrorCreatingIngestManifestFileEmptyFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input type not supported..
        /// </summary>
        internal static string ErrorInputTypeNotSupported {
            get {
                return ResourceManager.GetString("ErrorInputTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access policy must be created with call from AccessPolicyContext.Create..
        /// </summary>
        internal static string ErrorInvalidAccessPolicyType {
            get {
                return ResourceManager.GetString("ErrorInvalidAccessPolicyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Asset must be created with call from CloudMediaContext.Assets.Create..
        /// </summary>
        internal static string ErrorInvalidAssetType {
            get {
                return ResourceManager.GetString("ErrorInvalidAssetType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ContentKey must be returned from a call to IAsset.ContentKeys..
        /// </summary>
        internal static string ErrorInvalidContentKeyType {
            get {
                return ResourceManager.GetString("ErrorInvalidContentKeyType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ContentKeyType must be CommonEncryption or EnvelopeEncryption..
        /// </summary>
        internal static string ErrorUnsupportedContentKeyType {
            get {
                return ResourceManager.GetString("ErrorUnsupportedContentKeyType", resourceCulture);
            }
        }       

        /// <summary>
        ///   Looks up a localized string similar to File must be returned from a call to IAsset.Files..
        /// </summary>
        internal static string ErrorInvalidFileInfoType {
            get {
                return ResourceManager.GetString("ErrorInvalidFileInfoType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job must be created with call from CloudMediaContext.Jobs.Create..
        /// </summary>
        internal static string ErrorInvalidJobType {
            get {
                return ResourceManager.GetString("ErrorInvalidJobType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Guid.Empty is not a valid key identifier..
        /// </summary>
        internal static string ErrorInvalidKeyIdentifier {
            get {
                return ResourceManager.GetString("ErrorInvalidKeyIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid type to create link..
        /// </summary>
        internal static string ErrorInvalidLinkType {
            get {
                return ResourceManager.GetString("ErrorInvalidLinkType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manifest must be created with call from CloudMediaContext.BulkIngestManifests.Create..
        /// </summary>
        internal static string ErrorInvalidManifestType {
            get {
                return ResourceManager.GetString("ErrorInvalidManifestType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect number of inputs..
        /// </summary>
        internal static string ErrorInvalidNumberOfInputs {
            get {
                return ResourceManager.GetString("ErrorInvalidNumberOfInputs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Primary file not in passed in directory..
        /// </summary>
        internal static string ErrorInvalidPrimaryFile {
            get {
                return ResourceManager.GetString("ErrorInvalidPrimaryFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task input/output must be created with call from CloudMediaContext.Assets or a TaskOutputAsset..
        /// </summary>
        internal static string ErrorInvalidTaskInput {
            get {
                return ResourceManager.GetString("ErrorInvalidTaskInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task must be created with call from CloudMediaContext.Jobs.CreateTask..
        /// </summary>
        internal static string ErrorInvalidTaskType {
            get {
                return ResourceManager.GetString("ErrorInvalidTaskType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified localFileName is null or empty..
        /// </summary>
        internal static string ErrorLocalFilenameIsNullOrEmpty {
            get {
                return ResourceManager.GetString("ErrorLocalFilenameIsNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No output folder specified. The default save changes operation cannot be used without an output folder..
        /// </summary>
        internal static string ErrorNoOutputFolderSpecified {
            get {
                return ResourceManager.GetString("ErrorNoOutputFolderSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided primary file was not found - &apos;{0}&apos;..
        /// </summary>
        internal static string ErrorPrimaryFileNotFound {
            get {
                return ResourceManager.GetString("ErrorPrimaryFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Collection {0} is readonly for submitted Task..
        /// </summary>
        internal static string ErrorReadOnlyCollectionToSubmittedTask {
            get {
                return ResourceManager.GetString("ErrorReadOnlyCollectionToSubmittedTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TaskBody is not well-formed. Asset can&apos;t be parsed..
        /// </summary>
        internal static string ErrorTaskBodyMalformed {
            get {
                return ResourceManager.GetString("ErrorTaskBodyMalformed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploaded file name should be equal (case insensitive) to a IAssetFile.Name property. File name mismatch detected. Expected name {0}, actual file name is {1}..
        /// </summary>
        internal static string FileNameMismatch {
            get {
                return ResourceManager.GetString("FileNameMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find file for encryption.
        /// </summary>
        internal static string FileNotFoundForEncryption {
            get {
                return ResourceManager.GetString("FileNotFoundForEncryption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IAsset.Uri can&apos;t be created since invalid string value for property has been returned by REST layer.
        /// </summary>
        internal static string InvalidAssetUriException {
            get {
                return ResourceManager.GetString("InvalidAssetUriException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IngestManifestFile can&apos;t be created without passing parent manifest asset. Pass parent manifest asset or use IManifestAsset.ManifestAssetFiles.Create method..
        /// </summary>
        internal static string InvalidCreateManifestAssetFileOperation {
            get {
                return ResourceManager.GetString("InvalidCreateManifestAssetFileOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IngestManifestAsset can&apos;t be created without passing parent manifest. Pass parent manifest or use IManifest.ManifestAssets.Create method..
        /// </summary>
        internal static string InvalidCreateManifestAssetOperation {
            get {
                return ResourceManager.GetString("InvalidCreateManifestAssetOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid locator type..
        /// </summary>
        internal static string InvalidLocatorType {
            get {
                return ResourceManager.GetString("InvalidLocatorType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job not submitted yet and can&apos;t be canceled..
        /// </summary>
        internal static string InvalidOperationCancelForNotSubmittedJob {
            get {
                return ResourceManager.GetString("InvalidOperationCancelForNotSubmittedJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job template not saved yet and can&apos;t be deleted..
        /// </summary>
        internal static string InvalidOperationDeleteForNotSavedJobTemplate {
            get {
                return ResourceManager.GetString("InvalidOperationDeleteForNotSavedJobTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job not submitted yet and can&apos;t be deleted..
        /// </summary>
        internal static string InvalidOperationDeleteForNotSubmittedJob {
            get {
                return ResourceManager.GetString("InvalidOperationDeleteForNotSubmittedJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation can&apos;t be complited since cloudMediaContext is notInitialized. Call method InitCloudMediaContext..
        /// </summary>
        internal static string InvalidOperationException_CloudMediaContextIsNotInitialized {
            get {
                return ResourceManager.GetString("InvalidOperationException_CloudMediaContextIsNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job not submitted yet and it is not processing..
        /// </summary>
        internal static string InvalidOperationGetExecutionProgressTaskForNotSubmittedJob {
            get {
                return ResourceManager.GetString("InvalidOperationGetExecutionProgressTaskForNotSubmittedJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Asset already in a published state..
        /// </summary>
        internal static string InvalidOperationPublishForPublishedAsset {
            get {
                return ResourceManager.GetString("InvalidOperationPublishForPublishedAsset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job template already saved and can&apos;t be updated. To update a job template first create a copy using IJobTemplate.Copy method, perform the desired changes and then call IJobTemplate.Save method..
        /// </summary>
        internal static string InvalidOperationSaveForSavedJobTemplate {
            get {
                return ResourceManager.GetString("InvalidOperationSaveForSavedJobTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job already submitted and can&apos;t be submitted again..
        /// </summary>
        internal static string InvalidOperationSubmitForSubmittedJob {
            get {
                return ResourceManager.GetString("InvalidOperationSubmitForSubmittedJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only Origin locators can be updated..
        /// </summary>
        internal static string InvalidOperationUpdateForNotOriginLocator {
            get {
                return ResourceManager.GetString("InvalidOperationUpdateForNotOriginLocator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job not submitted yet and can&apos;t be updated..
        /// </summary>
        internal static string InvalidOperationUpdateForNotSubmittedJob {
            get {
                return ResourceManager.GetString("InvalidOperationUpdateForNotSubmittedJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Files can&apos;t be uploaded to asset with Published state..
        /// </summary>
        internal static string InvalidOperationUploadFilesForPublishedAsset {
            get {
                return ResourceManager.GetString("InvalidOperationUploadFilesForPublishedAsset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The interval must be greater than {0}s..
        /// </summary>
        internal static string MetricMonitoringIntervalOutOfRange {
            get {
                return ResourceManager.GetString("MetricMonitoringIntervalOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job must have at least one non temporary output asset..
        /// </summary>
        internal static string NoPermanentOutputs {
            get {
                return ResourceManager.GetString("NoPermanentOutputs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IFileInfo.Save operation is not supported when asset is not in initialized state..
        /// </summary>
        internal static string NotSupportedFileInfoSave {
            get {
                return ResourceManager.GetString("NotSupportedFileInfoSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output asset for non submitted job does not contain Files..
        /// </summary>
        internal static string NotSupportedFiles {
            get {
                return ResourceManager.GetString("NotSupportedFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output asset for non submitted job does not contain Locators..
        /// </summary>
        internal static string NotSupportedLocators {
            get {
                return ResourceManager.GetString("NotSupportedLocators", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Publish method is not supported for for asset of type OutputAsset..
        /// </summary>
        internal static string NotSupportedPublish {
            get {
                return ResourceManager.GetString("NotSupportedPublish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UploadFilesAsync method is not supported for asset of type OutputAsset..
        /// </summary>
        internal static string NotSupportedUploadFilesAsync {
            get {
                return ResourceManager.GetString("NotSupportedUploadFilesAsync", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Asset creation options indicates that storage encryption is used for given asset with id {0}. Please verify that asset has corresponding content key..
        /// </summary>
        internal static string StorageEncryptionContentKeyIsMissing {
            get {
                return ResourceManager.GetString("StorageEncryptionContentKeyIsMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown media processor {0}..
        /// </summary>
        internal static string UnknownMediaProcessor {
            get {
                return ResourceManager.GetString("UnknownMediaProcessor", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to parse expiration from token.  Please check the format of the token to ensure it is valid..
        /// </summary>
        internal static string UnableToParseExpirationFromToken {
            get {
                return ResourceManager.GetString("UnableToParseExpirationFromToken", resourceCulture);
    }
        }
    }
}
