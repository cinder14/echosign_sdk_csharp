using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;

namespace Cinder14.EchoSign.Models
{
    public class RequestFormField
    {
        /// <summary>
        /// Alignment => (string, optional) = ['LEFT' or 'RIGHT' or 'CENTER']: Alignment of the text.,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual Alignment? alignment { get; set; }
        /// <summary>
        /// BorderStyle => (string, optional) = ['SOLID' or 'DASHED' or 'BEVELED' or 'INSET' or 'UNDERLINE']: Style of the field's border.,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual BorderStyle? borderStyle { get; set; }
        /// <summary>
        /// (string, optional): Font color of the form field in RGB or HEX format,
        /// </summary>
        public virtual string fontColor { get; set; }
        /// <summary>
        /// (string, optional): Font name of the form field,
        /// </summary>
        public virtual string fontName { get; set; }
        /// <summary>
        /// (string, optional): Color of the field's border in RGB or HEX format,
        /// </summary>
        public virtual string borderColor { get; set; }
        /// <summary>
        /// (string, optional): Display label attached to the field,
        /// </summary>
        public virtual string displayLabel { get; set; }
        /// <summary>
        /// RadioCheckType => (string, optional) = ['CIRCLE' or 'CHECK' or 'CROSS' or 'DIAMOND' or 'SQUARE' or 'STAR']: The type of radio button (if field is radio button, identified by inputType). ,
        /// </summary>
        public virtual RadioCheckType? radioCheckType { get; set; }
        /// <summary>
        /// (string, optional): Expression to calculate value of the form field,
        /// </summary>
        public virtual string calculatedExpression { get; set; }
        /// <summary>
        /// (string, optional): Background color of the form field in RGB or HEX format,
        /// </summary>
        public virtual string backgroundColor { get; set; }
        /// <summary>
        /// (string, optional): The format of data in text field,
        /// </summary>
        public virtual string formatData { get; set; }
        /// <summary>
        ///  (integer, optional): Index of recipient, starting from 1, in recipients list passed in the request,
        /// </summary>
        public virtual string recipientIndex { get; set; }
        /// <summary>
        /// (string, optional): Format of field's value to be displayed based on the displayFormatType property.,
        /// </summary>
        public virtual string displayFormat { get; set; }
        /// <summary>
        /// ContentType => (string, optional) = ['DATA' or 'SIGNATURE_BLOCK' or 'SIGNATURE' or 'SIGNER_NAME' or 'SIGNER_FIRST_NAME' or 'SIGNER_LAST_NAME' or 'SIGNER_INITIALS' or 'SIGNER_EMAIL' or 'SIGNER_TITLE' or 'SIGNER_COMPANY' or 'SIGNATURE_DATE' or 'AGREEMENT_NAME' or 'AGREEMENT_MESSAGE' or 'TRANSACTION_ID' or 'SIGNATURE_STAMP' or 'CALC']: Content Type of the form field.,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ContentType? contentType { get; set; }
        /// <summary>
        /// (integer, optional): Maximum length of the input text field in terms of no. of characters,
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? maxLength { get; set; }
        /// <summary>
        /// (FormFieldLocation[]): All locations in a document where the form field is placed,
        /// </summary>
        public virtual FormFieldLocation[] locations { get; set; }
        /// <summary>
        /// (integer, optional): Minimum length of the input text field in terms of no. of characters,
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? minLength { get; set; }
        /// <summary>
        ///  (string): The name of the form field,
        /// </summary>
        public virtual string name { get; set; }
        /// <summary>
        /// InputType => (string, optional) = ['TEXT_FIELD' or 'MULTILINE' or 'PASSWORD' or 'RADIO' or 'CHECKBOX' or 'DROP_DOWN' or 'LISTBOX' or 'SIGNATURE' or 'PDF_SIGNATURE' or 'BUTTON' or 'BLOCK' or 'FILE_CHOOSER' or 'COMB' or 'UNSUPPORTED']: Input type of the form field,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual InputType? inputType { get; set; }

        /// <summary>
        /// (string, optional): Text that appears while hovering over the field
        /// </summary>
        public virtual string tooltip { get; set; }

        /// <summary>
        /// (string, optional): Formula used to calculate form field's value,
        /// </summary>
        public virtual string specialFormula { get; set; }
        /// <summary>
        /// (boolean, optional): true if it is a mandatory field to be filled by the signer, else false,
        /// </summary>
        public virtual bool required { get; set; }
        /// <summary>
        /// (string, optional): Default value of the form field,
        /// </summary>
        public virtual string defaultValue { get; set; }
        /// <summary>
        /// (double, optional): Lower bound of the number that can be entered by the signer,
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual double? minNumberValue { get; set; }
        /// <summary>
        /// (double, optional): Upper bound of the number that can be entered by the signer,
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual double? maxNumberValue { get; set; }
        /// <summary>
        /// (string, optional): Regular expression validation of the form field,
        /// </summary>
        public virtual string regularExpression { get; set; }
        /// <summary>
        /// (string, optional): Text to mask the masked form field,
        /// </summary>
        public virtual string maskingText { get; set; }

        /// <summary>
        ///  (string, optional): Error message to be shown to the signer if filled value doesn't match the validations of the form field,
        /// </summary>
        public virtual string specialErrMsg { get; set; }
        /// <summary>
        /// (float, optional): Font size of the form field in points,
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual float? fontSize { get; set; }
        /// <summary>
        /// (boolean, optional): true if the input entered by the signer has to be masked (like password), else false,
        /// </summary>
        public virtual bool masked { get; set; }
        /// <summary>
        /// (boolean, optional): true if it is a read-only field, else false,
        /// </summary>
        public virtual bool readOnly { get; set; }
        /// <summary>
        ///  (float, optional): Width of the field's border in pixels,
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual float? borderWidth { get; set; }
        /// <summary>
        ///  (boolean, optional): true if the field is hidden, else false,
        /// </summary>
        public virtual bool hidden { get; set; }
        /// <summary>
        ///  (string[], optional): Text values which are visible in a drop down form field,
        /// </summary>
        public virtual string[] visibleOptions { get; set; }
        /// <summary>
        /// (string[], optional): Text values which are hidden in a drop down form field,
        /// </summary>
        public virtual string[] hiddenOptions { get; set; }

        /// <summary>
        /// (FormFieldCondition[], optional): Conditions to be evaluated which decides the visibility of the form field in association with showOrHide property,
        /// </summary>
        public virtual FormFieldCondition[] conditions { get; set; }

        /// <summary>
        /// ShowOrHide => (string, optional) = ['SHOW' or 'HIDE' or 'DISABLE' or 'ENABLE']: Action to show/hide the form field is to be taken on the basis of evaluation of conditions.,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ShowOrHide? showOrHide { get; set; }

        /// <summary>
        /// FieldFormat => (string, optional) = ['CUSTOM' or 'DATE' or 'DATE_CUSTOM' or 'DATE_DD_MM_YY' or 'DATE_DD_MM_YYYY' or 'DATE_MM_DD_YY' or 'DATE_MM_DD_YYYY' or 'DATE_MM_YY' or 'EMAIL' or 'FORMULA' or 'MONEY' or 'MONEY_UK' or 'NONE' or 'NUMBER' or 'PERCENT' or 'PHONE' or 'PHONE_UK' or 'SOCIAL_SEC' or 'SPECIAL' or 'STRING' or 'STRING_ALPHA' or 'STRING_ALPHANUM' or 'STRING_NUM' or 'TIME' or 'XFA_PICTURE' or 'ZIP' or 'ZIP4' or 'ZIP_UK']: Format of the form field,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FieldFormat? format { get; set; }
        /// <summary>
        /// DisplayFormatType => (string, optional) = ['DEFAULT' or 'DATE' or 'NUMBER']: Format type of the text field. ,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DisplayFormatType? displayFormatType { get; set; }
        /// <summary>
        /// AnyOrAll => (string, optional) = ['ALL' or 'ANY']: It indicates if any one of the conditions or all of them have to be true.,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual AnyOrAll? anyOrAll { get; set; }
        
    }
}