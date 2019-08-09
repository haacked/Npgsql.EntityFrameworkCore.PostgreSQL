using System;

namespace Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Internal
{
    public static class NpgsqlAnnotationNames
    {
        public const string Prefix = "Npgsql:";

        public const string ValueGenerationStrategy = Prefix + "ValueGenerationStrategy";
        public const string HiLoSequenceName = Prefix + "HiLoSequenceName";
        public const string HiLoSequenceSchema = Prefix + "HiLoSequenceSchema";
        public const string IndexMethod = Prefix + "IndexMethod";
        public const string IndexOperators = Prefix + "IndexOperators";
        public const string IndexCollation = Prefix + "IndexCollation";
        public const string IndexSortOrder = Prefix + "IndexSortOrder";
        public const string IndexNullSortOrder = Prefix + "IndexNullSortOrder";
        public const string IndexInclude = Prefix + "IndexInclude";
        public const string PostgresExtensionPrefix = Prefix + "PostgresExtension:";
        public const string EnumPrefix = Prefix + "Enum:";
        public const string RangePrefix = Prefix + "Range:";
        public const string DatabaseTemplate = Prefix + "DatabaseTemplate";
        public const string Tablespace = Prefix + "Tablespace";
        public const string StorageParameterPrefix = Prefix + "StorageParameter:";
        public const string Comment = Prefix + "Comment";
        public const string UnloggedTable = Prefix + "UnloggedTable";
        public const string IdentityOptions = Prefix + "IdentitySequenceOptions";

        // Database model annotations

        /// <summary>
        /// Identifies the type of the PostgreSQL type of this column (e.g. array, range, base).
        /// </summary>
        public const string PostgresTypeType = Prefix + "PostgresTypeType";

        /// <summary>
        /// If this column's data type is an array, contains the data type of its elements.
        /// Otherwise null.
        /// </summary>
        public const string ElementDataType = Prefix + "ElementDataType";

        /// <summary>
        /// If the index contains an expression (rather than simple column references), the expression is contained here.
        /// This is currently unsupported and will be ignored.
        /// </summary>
        public const string IndexExpression = Prefix + "IndexExpression";

        [Obsolete("Replaced by ValueGenerationStrategy.SerialColumn")]
        public const string ValueGeneratedOnAdd = Prefix + "ValueGeneratedOnAdd";
    }
}
