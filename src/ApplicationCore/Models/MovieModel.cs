using System;
using System.Collections.Generic;

namespace NotFlex.ApplicationCore.Models
{
    public class MovieModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public byte Id { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        /// <value>
        /// The group name.
        /// </value>
        public string GroupName { get; set; }
        /// <summary>
        /// Gets or sets the released date.
        /// </summary>
        /// <value>
        /// The released date.
        /// </value>
        public DateTime ReleasedDate { get; set; }
        /// <summary>
        /// Gets or sets the director.
        /// </summary>
        /// <value>
        /// The director.
        /// </value>
        public string Director { get; set; }
        /// <summary>
        /// Gets or sets the distributed by.
        /// </summary>
        /// <value>
        /// The distributed by.
        /// </value>
        public string DistributedBy { get; set; }
        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public string Length { get; set; }
        /// <summary>
        /// Gets or sets the poster image.
        /// </summary>
        /// <value>
        /// The poster image.
        /// </value>
        public string PosterImage { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is feature.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is feature; otherwise, <c>false</c>.
        /// </value>
        public bool IsFeature { get; set; }
        /// <summary>
        /// Gets or sets the movie category collection.
        /// </summary>
        /// <value>
        /// The movie category collection.
        /// </value>
        public IReadOnlyCollection<string> Category { get; set; }
    }
}
