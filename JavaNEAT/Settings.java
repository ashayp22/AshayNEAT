/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mygame;

/**
 *
 * @author ashay
 */
public class Settings {
	public static int YOUNG_BONUS_AGE_THRESHOLD = 10;
	public static double YOUNG_FITNESS_BONUS = 1.2;
	public static int OLD_AGE_THRESHOLD = 50;
	public static double OLD_AGE_PENALTY = 0.7;
	public static int NUM_GENS_ALLOWED_NO_IMPROVEMENT = 3;
	public static int NUM_AI = 20;
	public static double CROSSOVER_RATE = 0.7;
	public static int MAX_PERMITTED_NEURONS = 12;
	public static double CHANCE_ADD_NODE = 0.05;
	public static int NUM_TRYS_TO_FIND_OLD_LINK = 10;
	public static double CHANCE_ADD_LINK = 0.3;
	public static double CHANCE_ADD_RECURRENT_LINK = 0.05;
	public static int NUM_TRYS_TO_FIND_LOOPED_LINK = 0;
	public static int NUM_ADD_LINK_ATTEMPTS = 10;
	public static double MUTATION_RATE = 0.2;
	public static double PROBABILITY_WEIGHT_REPLACED = 0.1;
	public static double MAX_WEIGHT_PERTUBATION = 0.5;
	public static double ACTIVATION_MUTATION_RATE = 0.1;
	public static double MAX_ACTIVATION_PERTUBATION = 0.5;
}