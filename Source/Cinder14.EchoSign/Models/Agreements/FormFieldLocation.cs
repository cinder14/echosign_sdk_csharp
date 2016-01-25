namespace Cinder14.EchoSign.Models
{
    public class FormFieldLocation
    {
        /// <summary>
        /// (double): Height of the form field in pixels,
        /// </summary>
        public virtual double height { get; set; }
        /// <summary>
        /// (double): Width of the form field in pixels,
        /// </summary>
        public virtual double width { get; set; }
        /// <summary>
        /// (int): Number of the page where form field has to be placed, starting from 1.,
        /// </summary>
        public virtual int pageNumber { get; set; }
        /// <summary>
        ///  (double): No. of pixels from left of the page for form field placement,
        /// </summary>
        public virtual double left { get; set; }
        /// <summary>
        /// (double): No. of pixels from bottom of the page for form field placement
        /// </summary>
        public virtual double top { get; set; }
    }
}