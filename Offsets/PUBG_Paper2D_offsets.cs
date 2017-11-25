/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMaterialExpressionSpriteTextureSampler
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bSampleAdditionalTextures = 0x01B8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x01B9;

		///<summary><![CDATA[int]]></summary>
		public const int AdditionalSlotIndex = 0x01BC;

		///<summary><![CDATA[FText]]></summary>
		public const int SlotDisplayName = 0x01C0;

	}

	public class APaperCharacter
	{
		///<summary><![CDATA[UPaperFlipbookComponent *]]></summary>
		public const int Sprite = 0x07E0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x07E8;

	}

	public class UPaperFlipbook
	{
		///<summary><![CDATA[float]]></summary>
		public const int FramesPerSecond = 0x0028;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x002C;

		///<summary><![CDATA[TArray<FPaperFlipbookKeyFrame>]]></summary>
		public const int KeyFrames = 0x0030;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int DefaultMaterial = 0x0040;

		///<summary><![CDATA[TEnumAsByte<EFlipbookCollisionMode>]]></summary>
		public const int CollisionSource = 0x0048;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0049;

	}

	public class APaperFlipbookActor
	{
		///<summary><![CDATA[UPaperFlipbookComponent *]]></summary>
		public const int RenderComponent = 0x03B0;

	}

	public class UPaperFlipbookComponent
	{
		///<summary><![CDATA[UPaperFlipbook *]]></summary>
		public const int SourceFlipbook = 0x0930;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int Material = 0x0938;

		///<summary><![CDATA[float]]></summary>
		public const int PlayRate = 0x0940;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLooping = 0x0944;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReversePlayback = 0x0944;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPlaying = 0x0944;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0945;

		///<summary><![CDATA[float]]></summary>
		public const int AccumulatedTime = 0x0948;

		///<summary><![CDATA[int]]></summary>
		public const int CachedFrameIndex = 0x094C;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int SpriteColor = 0x0950;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int CachedBodySetup = 0x0960;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnFinishedPlaying = 0x0968;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0978;

	}

	public class APaperGroupedSpriteActor
	{
		///<summary><![CDATA[UPaperGroupedSpriteComponent *]]></summary>
		public const int RenderComponent = 0x03B0;

	}

	public class UPaperGroupedSpriteComponent
	{
		///<summary><![CDATA[TArray<UMaterialInterface * >]]></summary>
		public const int InstanceMaterials = 0x0930;

		///<summary><![CDATA[TArray<FSpriteInstanceData>]]></summary>
		public const int PerInstanceSpriteData = 0x0940;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0950;

	}

	public class UPaperRuntimeSettings
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bEnableSpriteAtlasGroups = 0x0028;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableTerrainSplineEditing = 0x0029;

		///<summary><![CDATA[bool]]></summary>
		public const int bResizeSpriteDataToMatchTextures = 0x002A;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData00 = 0x002B;

	}

	public class UPaperSprite
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int SourceUV = 0x0038;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int SourceDimension = 0x0040;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int SourceTexture = 0x0048;

		///<summary><![CDATA[TArray<UTexture * >]]></summary>
		public const int AdditionalSourceTextures = 0x0050;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int BakedSourceUV = 0x0060;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int BakedSourceDimension = 0x0068;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int BakedSourceTexture = 0x0070;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int DefaultMaterial = 0x0078;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int AlternateMaterial = 0x0080;

		///<summary><![CDATA[TArray<FPaperSpriteSocket>]]></summary>
		public const int Sockets = 0x0088;

		///<summary><![CDATA[TEnumAsByte<ESpriteCollisionMode>]]></summary>
		public const int SpriteCollisionDomain = 0x0098;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0099;

		///<summary><![CDATA[float]]></summary>
		public const int PixelsPerUnrealUnit = 0x009C;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int BodySetup = 0x00A0;

		///<summary><![CDATA[int]]></summary>
		public const int AlternateMaterialSplitIndex = 0x00A8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x00AC;

		///<summary><![CDATA[TArray<FVector4>]]></summary>
		public const int BakedRenderData = 0x00B0;

	}

	public class APaperSpriteActor
	{
		///<summary><![CDATA[UPaperSpriteComponent *]]></summary>
		public const int RenderComponent = 0x03B0;

	}

	public class UPaperSpriteComponent
	{
		///<summary><![CDATA[UPaperSprite *]]></summary>
		public const int SourceSprite = 0x0930;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int MaterialOverride = 0x0938;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int SpriteColor = 0x0940;

	}

	public class APaperTerrainActor
	{
		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int DummyRoot = 0x03B0;

		///<summary><![CDATA[UPaperTerrainSplineComponent *]]></summary>
		public const int SplineComponent = 0x03B8;

		///<summary><![CDATA[UPaperTerrainComponent *]]></summary>
		public const int RenderComponent = 0x03C0;

	}

	public class UPaperTerrainComponent
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bClosedSpline = 0x0830;

		///<summary><![CDATA[bool]]></summary>
		public const int bFilledSpline = 0x0831;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x0832;

		///<summary><![CDATA[UPaperTerrainSplineComponent *]]></summary>
		public const int AssociatedSpline = 0x0838;

		///<summary><![CDATA[int]]></summary>
		public const int RandomSeed = 0x0840;

		///<summary><![CDATA[float]]></summary>
		public const int SegmentOverlapAmount = 0x0844;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int TerrainColor = 0x0848;

		///<summary><![CDATA[int]]></summary>
		public const int ReparamStepsPerSegment = 0x0858;

		///<summary><![CDATA[TEnumAsByte<ESpriteCollisionMode>]]></summary>
		public const int SpriteCollisionDomain = 0x085C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x085D;

		///<summary><![CDATA[float]]></summary>
		public const int CollisionThickness = 0x0860;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0864;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int CachedBodySetup = 0x0868;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData03 = 0x0870;

	}

	public class UPaperTerrainMaterial
	{
		///<summary><![CDATA[TArray<FPaperTerrainMaterialRule>]]></summary>
		public const int Rules = 0x0030;

		///<summary><![CDATA[UPaperSprite *]]></summary>
		public const int InteriorFill = 0x0040;

	}

	public class UPaperTerrainSplineComponent
	{
		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData00 = 0x0910;

	}

	public class UPaperTileLayer
	{
		///<summary><![CDATA[FText]]></summary>
		public const int LayerName = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int LayerWidth = 0x0040;

		///<summary><![CDATA[int]]></summary>
		public const int LayerHeight = 0x0044;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHiddenInGame = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLayerCollides = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideCollisionThickness = 0x0048;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideCollisionOffset = 0x0048;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[float]]></summary>
		public const int CollisionThicknessOverride = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int CollisionOffsetOverride = 0x0050;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int LayerColor = 0x0054;

		///<summary><![CDATA[int]]></summary>
		public const int AllocatedWidth = 0x0064;

		///<summary><![CDATA[int]]></summary>
		public const int AllocatedHeight = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x006C;

		///<summary><![CDATA[TArray<FPaperTileInfo>]]></summary>
		public const int AllocatedCells = 0x0070;

		///<summary><![CDATA[UPaperTileSet *]]></summary>
		public const int TileSet = 0x0080;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int AllocatedGrid = 0x0088;

	}

	public class UPaperTileMap
	{
		///<summary><![CDATA[int]]></summary>
		public const int MapWidth = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int MapHeight = 0x002C;

		///<summary><![CDATA[int]]></summary>
		public const int TileWidth = 0x0030;

		///<summary><![CDATA[int]]></summary>
		public const int TileHeight = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int PixelsPerUnrealUnit = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int SeparationPerTileX = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int SeparationPerTileY = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int SeparationPerLayer = 0x0044;

		///<summary><![CDATA[TAssetPtr<UPaperTileSet>]]></summary>
		public const int SelectedTileSet = 0x0048;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int Material = 0x0068;

		///<summary><![CDATA[TArray<UPaperTileLayer * >]]></summary>
		public const int TileLayers = 0x0070;

		///<summary><![CDATA[float]]></summary>
		public const int CollisionThickness = 0x0080;

		///<summary><![CDATA[TEnumAsByte<ESpriteCollisionMode>]]></summary>
		public const int SpriteCollisionDomain = 0x0084;

		///<summary><![CDATA[TEnumAsByte<ETileMapProjectionMode>]]></summary>
		public const int ProjectionMode = 0x0085;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0086;

		///<summary><![CDATA[int]]></summary>
		public const int HexSideLength = 0x0088;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x008C;

		///<summary><![CDATA[UBodySetup *]]></summary>
		public const int BodySetup = 0x0090;

		///<summary><![CDATA[int]]></summary>
		public const int LayerNameIndex = 0x0098;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x009C;

	}

	public class APaperTileMapActor
	{
		///<summary><![CDATA[UPaperTileMapComponent *]]></summary>
		public const int RenderComponent = 0x03B0;

	}

	public class UPaperTileMapComponent
	{
		///<summary><![CDATA[int]]></summary>
		public const int MapWidth = 0x0930;

		///<summary><![CDATA[int]]></summary>
		public const int MapHeight = 0x0934;

		///<summary><![CDATA[int]]></summary>
		public const int TileWidth = 0x0938;

		///<summary><![CDATA[int]]></summary>
		public const int TileHeight = 0x093C;

		///<summary><![CDATA[UPaperTileSet *]]></summary>
		public const int DefaultLayerTileSet = 0x0940;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int Material = 0x0948;

		///<summary><![CDATA[TArray<UPaperTileLayer * >]]></summary>
		public const int TileLayers = 0x0950;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int TileMapColor = 0x0960;

		///<summary><![CDATA[int]]></summary>
		public const int UseSingleLayerIndex = 0x0970;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseSingleLayer = 0x0974;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0975;

		///<summary><![CDATA[UPaperTileMap *]]></summary>
		public const int TileMap = 0x0978;

	}

	public class UPaperTileSet
	{
		///<summary><![CDATA[FIntPoint]]></summary>
		public const int TileSize = 0x0028;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int TileSheet = 0x0030;

		///<summary><![CDATA[FIntMargin]]></summary>
		public const int BorderMargin = 0x0038;

		///<summary><![CDATA[FIntPoint]]></summary>
		public const int PerTileSpacing = 0x0048;

		///<summary><![CDATA[FIntPoint]]></summary>
		public const int DrawingOffset = 0x0050;

		///<summary><![CDATA[int]]></summary>
		public const int WidthInTiles = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int HeightInTiles = 0x005C;

		///<summary><![CDATA[int]]></summary>
		public const int AllocatedWidth = 0x0060;

		///<summary><![CDATA[int]]></summary>
		public const int AllocatedHeight = 0x0064;

		///<summary><![CDATA[TArray<FPaperTileMetadata>]]></summary>
		public const int PerTileData = 0x0068;

		///<summary><![CDATA[TArray<FPaperTileSetTerrain>]]></summary>
		public const int Terrains = 0x0078;

		///<summary><![CDATA[int]]></summary>
		public const int TileWidth = 0x0088;

		///<summary><![CDATA[int]]></summary>
		public const int TileHeight = 0x008C;

		///<summary><![CDATA[int]]></summary>
		public const int Margin = 0x0090;

		///<summary><![CDATA[int]]></summary>
		public const int Spacing = 0x0094;

	}

}
