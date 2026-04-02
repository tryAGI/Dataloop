#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class APIAnnotationCoordinateTypesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.APIAnnotationCoordinateTypes>
    {
        /// <inheritdoc />
        public override global::Dataloop.APIAnnotationCoordinateTypes Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("x")) __score0++;
            if (__jsonProps.Contains("y")) __score0++;
            if (__jsonProps.Contains("z")) __score0++;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            if (__jsonProps.Contains("box")) __score3++;
            if (__jsonProps.Contains("note")) __score3++;
            if (__jsonProps.Contains("updatedAt")) __score3++;
            if (__jsonProps.Contains("updatedBy")) __score3++;
            var __score4 = 0;
            var __score5 = 0;
            if (__jsonProps.Contains("instanceId")) __score5++;
            if (__jsonProps.Contains("templateId")) __score5++;
            var __score6 = 0;
            var __score7 = 0;
            var __score8 = 0;
            if (__jsonProps.Contains("angle")) __score8++;
            if (__jsonProps.Contains("center")) __score8++;
            if (__jsonProps.Contains("rx")) __score8++;
            if (__jsonProps.Contains("ry")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("angle")) __score9++;
            if (__jsonProps.Contains("back_bl")) __score9++;
            if (__jsonProps.Contains("back_br")) __score9++;
            if (__jsonProps.Contains("back_tl")) __score9++;
            if (__jsonProps.Contains("back_tr")) __score9++;
            if (__jsonProps.Contains("front_bl")) __score9++;
            if (__jsonProps.Contains("front_br")) __score9++;
            if (__jsonProps.Contains("front_tl")) __score9++;
            if (__jsonProps.Contains("front_tr")) __score9++;
            var __score10 = 0;
            var __score11 = 0;
            if (__jsonProps.Contains("text")) __score11++;
            var __score12 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::Dataloop.Point? point = default;
            global::System.Collections.Generic.IList<global::Dataloop.Point>? aPIAnnotationCoordinateTypesVariant2 = default;
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? aPIAnnotationCoordinateTypesVariant3 = default;
            global::Dataloop.APINoteAnnotationCoordinatesV1? noteCoordinatesV1 = default;
            string? aPIAnnotationCoordinateTypesVariant5 = default;
            global::Dataloop.PoseCoordinates? poseCoordinates = default;
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? polygonCoordinatesV1 = default;
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? polylineCoordinatesV3 = default;
            global::Dataloop.EllipseCoordinatesV1? ellipseCoordinatesV1 = default;
            global::Dataloop.CubeCoordinatesV1? cubeCoordinatesV1 = default;
            global::System.Collections.Generic.IList<object>? boxCoordinates = default;
            global::Dataloop.ItemDescriptionCoordinates? itemDescriptionCoordinates = default;
            global::Dataloop.IRefImageAnnotationsType? refImageAnnotationsType = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        point = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.Point>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        aPIAnnotationCoordinateTypesVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Dataloop.Point>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        aPIAnnotationCoordinateTypesVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        noteCoordinatesV1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.APINoteAnnotationCoordinatesV1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        aPIAnnotationCoordinateTypesVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        poseCoordinates = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.PoseCoordinates>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        polygonCoordinatesV1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        polylineCoordinatesV3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        ellipseCoordinatesV1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.EllipseCoordinatesV1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        cubeCoordinatesV1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.CubeCoordinatesV1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        boxCoordinates = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<object>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        itemDescriptionCoordinates = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ItemDescriptionCoordinates>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        refImageAnnotationsType = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IRefImageAnnotationsType>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (point == null && aPIAnnotationCoordinateTypesVariant2 == null && aPIAnnotationCoordinateTypesVariant3 == null && noteCoordinatesV1 == null && aPIAnnotationCoordinateTypesVariant5 == null && poseCoordinates == null && polygonCoordinatesV1 == null && polylineCoordinatesV3 == null && ellipseCoordinatesV1 == null && cubeCoordinatesV1 == null && boxCoordinates == null && itemDescriptionCoordinates == null && refImageAnnotationsType == null)
            {
                try
                {
                    point = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.Point>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    aPIAnnotationCoordinateTypesVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Dataloop.Point>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    aPIAnnotationCoordinateTypesVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    noteCoordinatesV1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.APINoteAnnotationCoordinatesV1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    aPIAnnotationCoordinateTypesVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    poseCoordinates = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.PoseCoordinates>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    polygonCoordinatesV1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    polylineCoordinatesV3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    ellipseCoordinatesV1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.EllipseCoordinatesV1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    cubeCoordinatesV1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.CubeCoordinatesV1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    boxCoordinates = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<object>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    itemDescriptionCoordinates = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ItemDescriptionCoordinates>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    refImageAnnotationsType = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IRefImageAnnotationsType>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.APIAnnotationCoordinateTypes(
                point,

                aPIAnnotationCoordinateTypesVariant2,

                aPIAnnotationCoordinateTypesVariant3,

                noteCoordinatesV1,

                aPIAnnotationCoordinateTypesVariant5,

                poseCoordinates,

                polygonCoordinatesV1,

                polylineCoordinatesV3,

                ellipseCoordinatesV1,

                cubeCoordinatesV1,

                boxCoordinates,

                itemDescriptionCoordinates,

                refImageAnnotationsType
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.APIAnnotationCoordinateTypes value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPoint)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Point, typeof(global::Dataloop.Point), options);
            }
            else if (value.IsAPIAnnotationCoordinateTypesVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.APIAnnotationCoordinateTypesVariant2, typeof(global::System.Collections.Generic.IList<global::Dataloop.Point>), options);
            }
            else if (value.IsAPIAnnotationCoordinateTypesVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.APIAnnotationCoordinateTypesVariant3, typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>), options);
            }
            else if (value.IsNoteCoordinatesV1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NoteCoordinatesV1, typeof(global::Dataloop.APINoteAnnotationCoordinatesV1), options);
            }
            else if (value.IsAPIAnnotationCoordinateTypesVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.APIAnnotationCoordinateTypesVariant5, typeof(string), options);
            }
            else if (value.IsPoseCoordinates)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PoseCoordinates, typeof(global::Dataloop.PoseCoordinates), options);
            }
            else if (value.IsPolygonCoordinatesV1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PolygonCoordinatesV1, typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>), options);
            }
            else if (value.IsPolylineCoordinatesV3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PolylineCoordinatesV3, typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>), options);
            }
            else if (value.IsEllipseCoordinatesV1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EllipseCoordinatesV1, typeof(global::Dataloop.EllipseCoordinatesV1), options);
            }
            else if (value.IsCubeCoordinatesV1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CubeCoordinatesV1, typeof(global::Dataloop.CubeCoordinatesV1), options);
            }
            else if (value.IsBoxCoordinates)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BoxCoordinates, typeof(global::System.Collections.Generic.IList<object>), options);
            }
            else if (value.IsItemDescriptionCoordinates)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ItemDescriptionCoordinates, typeof(global::Dataloop.ItemDescriptionCoordinates), options);
            }
            else if (value.IsRefImageAnnotationsType)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RefImageAnnotationsType, typeof(global::Dataloop.IRefImageAnnotationsType), options);
            }
        }
    }
}