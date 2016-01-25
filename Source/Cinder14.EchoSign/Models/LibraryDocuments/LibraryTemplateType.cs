namespace Cinder14.EchoSign.Models
{
    public enum LibraryTemplateType
    {
        /// <summary>
        /// (enum): The template is a document template, which means that it can be sent as an agreement but its fields cannot be applied to another agreement,
        /// </summary>
        DOCUMENT,
        /// <summary>
        /// (enum): The template is a form field layer template, which means that it cannot be sent as an agreement but its fields can be applied to another agreement through the web application authoring page or through the API
        /// </summary>
        FORM_FIELD_LAYER
    }
}