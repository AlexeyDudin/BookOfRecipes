import { TagClass } from "./TagClass";
import {IngridientClass} from "./IngridientClass";
import { StepClass } from "./StepClass";
import { User } from "./user";
import { RecipePhoto } from "./RecipePhoto";

export class Recipe {
    id: number = 0;
    title: string = "";
    owner!: User;
    text: string = "";
    tags: TagClass [] = [];
    timer: number = 0;
    persons: number = 0;
    ingridients: IngridientClass[] = [{text: "", count: 0}];
    step: StepClass[] = [{ count: 1, description: ""}];
    likeCount: number = 0;
    imagePath!: RecipePhoto;
    }