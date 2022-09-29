import { TagClass } from "./TagClass";
import {IngridientClass as IngridientDto} from "./IngridientClass";
import { StepClass as StepDto } from "./StepClass";
import { User } from "./user";
import { RecipePhoto } from "./RecipePhoto";

export class RecipeDto {
    id: number = 0;
    title: string = "";
    owner!: User | null;
    descrptionText: string = "";
    tags: TagClass [] = [];
    timeRemaining: number = 0;
    countPersons: number = 0;
    ingridients: IngridientDto[] = [{name: "", products: ""}];
    steps: StepDto[] = [{ number: 1, description: ""}];
    likeCount: number = 0;
    recipePhoto!: RecipePhoto;
    }